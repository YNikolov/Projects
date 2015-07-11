namespace ArticlesForum.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    
    using ArticlesForum.Models;
    using ArticlesForum.Data;

    public class ArticlesForumDbContext : IdentityDbContext<User>
    {
        public ArticlesForumDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ArticlesForumDbContext, Configuration>());
        }

        public virtual IDbSet<Article> Articles { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }               
                
        public static ArticlesForumDbContext Create()
        {
            return new ArticlesForumDbContext();
        }
    }

}
