namespace LaptopListingSystem.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using LaptopListingSystem.Models;
    

    public sealed class Configuration : DbMigrationsConfiguration<LaptopListingSystemDbContext>
    {      
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;

        }
        //TODO create data base for seeding
        protected override void Seed(LaptopListingSystemDbContext context)
        {
            if (context.Laptops.Count() > 0)
            {
                return;
            }

            Random rand = new Random();

            Manufacturer sampleManufacturer = new Manufacturer { Name = "HP" };
            User user = new User() { UserName = "TestUser", Email = "TestMail@test.com" };

            for (int i = 0; i < 10; i++)
            {
                Laptop laptop = new Laptop();
                laptop.HardDisk = rand.Next(10, 1000);
                laptop.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhxASyvj0xQzTE2aZ0n83GTrmUY7PR3M-k0k5UyQnP8K9e6pX3LQ";
                laptop.Manufacturer = sampleManufacturer;
                laptop.Model = "ideapad";
                laptop.ScreenSize = 15.4;
                laptop.Price = rand.Next(600, 3000);
                laptop.Ram = rand.Next(1, 16);
                laptop.Weight = 3;

                var votesCount = rand.Next(0, 10);
                for (int j = 0; j < votesCount; j++)
                {
                    laptop.Votes.Add(new Vote { Laptop = laptop, User = user });
                }

                var commentsCount = rand.Next(0, 10);
                for (int j = 0; j < commentsCount; j++)
                {
                    laptop.Comments.Add(new Comment { Content = "Sample sample...", User = user });
                }

                context.Laptops.Add(laptop);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}

