namespace ArticlesForum.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using ArticlesForum.Models;

    public class ArticlesForumData : IArticlesForumData
    {
        private readonly DbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public ArticlesForumData(DbContext context)
        {
            this.context = context;
        }

        public IRepository<Category> Categories
        {
            get
            {
                return this.GetRepository<Category>();
            }
        }

        public IRepository<Article> Articles
        {
            get
            {
                return this.GetRepository<Article>();
            }
        }

        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }

        public IRepository<Comment> Comments
        {
            get
            {
                return this.GetRepository<Comment>();
            }
        }

        public DbContext Context
        {
            get
            {
                return this.context;
            }
        }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// The number of objects written to the underlying database.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
