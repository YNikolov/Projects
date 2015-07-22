namespace ArticlesForum.Data
{
    using System;
    using System.Data.Entity;
    using ArticlesForum.Models;

    public interface IArticlesForumData
    {
        DbContext Context { get; }

        IRepository<Category> Categories { get; }

        IRepository<Comment> Comments { get; }

        IRepository<Article> Articles { get; }

        IRepository<User> Users { get; }
        
        IRepository<Image> Images { get; }

        void Dispose();

        int SaveChanges();
    }
}

