namespace LaptopListingSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using LaptopListingSystem.Models;

    public class LaptopListingSystemData : ILaptopListingSystemData
    {

        private readonly DbContext context;
        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public LaptopListingSystemData(DbContext context)
        {
            this.context = context;
        }


        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IRepository<Manufacturer> Manufacturers
        {
            get { return this.GetRepository<Manufacturer>(); }
        }

        public IRepository<Laptop> Laptops
        {
            get { return this.GetRepository<Laptop>(); }
        }

        public IRepository<Comment> Comments
        {
            get { return this.GetRepository<Comment>(); }
        }

        public IRepository<Vote> Votes
        {
            get { return this.GetRepository<Vote>(); }
        }
        public DbContext Context
        {
            get { return this.context; }
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

        public void Dispose()
        {
            this.context.Dispose();
        } 

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }
    }
}
