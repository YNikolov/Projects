namespace ArticlesForum.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using ArticlesForum.Common;
    using ArticlesForum.Data;
    using ArticlesForum.Models;

    public sealed class Configuration : DbMigrationsConfiguration<ArticlesForumDbContext>
    {
        private UserManager<User> userManager;
        
        private IRandomStrGenerator random;
        
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.random = new RandomStrGenerator();
        }

        protected override void Seed(ArticlesForumDbContext context)
        {
            this.userManager = new UserManager<User>(new UserStore<User>(context));
            this.SeedRoles(context);
            this.SeedUsers(context);
            this.SeedCategoriesWithArticlesWithComments(context);
        }

        private void SeedRoles(ArticlesForumDbContext context)
        {
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.AdminRole));
            context.SaveChanges();
        }

        private void SeedUsers(ArticlesForumDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            for (int i = 0; i < 6; i++)
            {
                var user = new User
                {
                    Email = string.Format("{0}@{1}.com", this.random.RandomString(6, 16), this.random.RandomString(6, 16)),
                    UserName = this.random.RandomString(6, 16)
                };

                this.userManager.Create(user, "123456");
            }

            var adminUser = new User
            {
                Email = "admin@mysite.com",
                UserName = "Administrator"
            };

            this.userManager.Create(adminUser, "admin123456");

            this.userManager.AddToRole(adminUser.Id, GlobalConstants.AdminRole);
            
        }

        private void SeedCategoriesWithArticlesWithComments(ArticlesForumDbContext context)
        {
            var users = context.Users.Take(6).ToList();

            for (int i = 0; i < 5; i++)
            {
                var category = new Category()
                {
                    Name = this.random.RandomString(5, 8)                    
                    
                };                     
            
                for (int j = 0; j < 5; j++)
                {
                    var article = new Article()
                    {
                        Author = users[this.random.RandomNumber(0, users.Count - 1)],
                        ImageUrl = "http://www.google.bg/imgres?imgurl=http://www.freearticlemarketing.co.uk/wp-content/uploads/2012/01/Free-Marketing-387x250.jpg&imgrefurl=http://www.freearticlemarketing.co.uk/tag/affiliate&h=250&w=387&tbnid=okFO4wiq9FARWM:&zoom=1&docid=81y_B-65M1OQsM&ei=Re6jVam5FYWosgGjgZ-IAg&tbm=isch&ved=0CB0QMygAMABqFQoTCOnv5pPK2MYCFQWULAodo8AHIQ",
                        //Category = categories[this.random.RandomNumber(0, categories.Count - 1)],
                        Title = this.random.RandomString(5, 30),
                        Content = this.random.RandomString(100, 400)
                    };

                    //var articles = context.Articles.ToList();

                    for (int c = 0; c < 5; c++)
                    {
                        var comment = new Comment()
                        {
                            //Article = articles[this.random.RandomNumber(0, articles.Count - 1)],
                            Author = users[this.random.RandomNumber(0, users.Count - 1)],
                            Content = this.random.RandomString(100, 200)                    
                        };
                        article.Comments.Add(comment);
                    }
                    category.Articles.Add(article);
                }
                context.Categories.Add(category);
            }
            
            //var categories = context.Categories.Take(5).ToList();
            

            context.SaveChanges();
        }

    }
}
