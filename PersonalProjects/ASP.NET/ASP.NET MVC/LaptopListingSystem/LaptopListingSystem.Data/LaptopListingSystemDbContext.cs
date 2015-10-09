namespace LaptopListingSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using System.Threading.Tasks;

    using LaptopListingSystem.Models;

    public class LaptopListingSystemDbContext : IdentityDbContext<User>
    {
        public LaptopListingSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Manufacturer> Manufacturers { get; set; }

        public virtual IDbSet<Laptop> Laptops { get; set; }
        public virtual IDbSet<Comment> Comments { get; set; }
        public virtual IDbSet<Vote> Votes { get; set; }

        public static LaptopListingSystemDbContext Create()
        {
            return new LaptopListingSystemDbContext();
        }
    }
}
