namespace ArticlesForum.Data
{    
    using Microsoft.AspNet.Identity.EntityFramework;
    using ArticlesForum.Models;

    public class ArticlesForumDbContext : IdentityDbContext<User>
    {
        public ArticlesForumDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ArticlesForumDbContext Create()
        {
            return new ArticlesForumDbContext();
        }
    }

}
