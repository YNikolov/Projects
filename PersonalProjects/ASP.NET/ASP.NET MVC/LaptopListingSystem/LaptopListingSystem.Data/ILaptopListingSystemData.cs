namespace LaptopListingSystem.Data
{
    using System;
    using System.Data.Entity;
    
    using LaptopListingSystem.Models;

    public interface ILaptopListingSystemData
    {
        DbContext Context { get; }        
        
        IRepository<User> Users { get; }
        
        IRepository<Manufacturer> Manufacturers { get; }
        
        IRepository<Laptop> Laptops { get; }
        
        IRepository<Comment> Comments { get; }
        
        IRepository<Vote> Votes { get; }

        void Dispose();
        
        int SaveChanges();
    }
}
