namespace MusicArtists.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using MusicArtists.Data;
    using MusicArtists.Model;
    using MusicArtists.Data.Interfaces;

    public sealed class Configuration : DbMigrationsConfiguration<MusicArtistsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            
            //this.ContextKey = "MusicArtists.Data.MusicArtistsDbContext";
        }

        protected override void Seed(MusicArtistsDbContext context)
        {
           // this.SeedArtists(context);
            //this.SeedAlbums(context);
            //this.SeedSongs(context);
        }

        private void SeedArtists(IMusicArtistsDbContext context)
        {
            //if (context.Artists.Any())
            //{
            //    return;
            //}
            //var christina = new Artist()
            //{
            //    Name = "Christina Aguilera",
            //    Country = "USA",
            //    //BirthDay = new DateTime(2008, 3, 15)
            //};
            //christina.Albums = new List<Album>()
            //{
            //   new Album() 
            //   {
            //        Name = "Dirrty",
            //        Genre = "Pop",
            //        Producer = "Christina Aguilera",
            //        //Year = DateTime.Parse("09/19/2013 00:29 AM", new System.Globalization.CultureInfo("en-US", false)),
            //        Songs = new List<Song>()
            //        {
            //            new Song()
            //            {
            //                Genre = "Pop",
            //                Name = "Dirrty",
            //                Artist = "Christina Aguilera"
            //            }
            //        }
            //   },
            //   new Album() 
            //   {
            //        Name = "Stripped",
            //        Genre = "Pop",
            //        Producer = "Christina Aguilera",
            //        //Year = DateTime.Parse("09/19/2013 00:29 AM", new System.Globalization.CultureInfo("en-US", false)),
            //        Songs = new List<Song>()
            //        {
            //            new Song()
            //            {
            //                Genre = "Pop",
            //                Name = "Stripped",
            //                Artist = "Christina Aguilera"
            //            },
            //            new Song()
            //            {
            //                Genre = "Pop",
            //                Name = "Fighter",
            //                Artist = "Christina Aguilera"
            //            },
            //            new Song()
            //            {
            //                Genre = "Pop",
            //                Name = "Beautyfull",
            //                Artist = "Christina Aguilera"
            //            }
            //        }
            //   },
            //   new Album() 
            //   {
            //        Name = "BackToBasics",
            //        Genre = "Pop",
            //        Producer = "Christina Aguilera",
            //        //Year = new DateTime(2013,12,1),
            //        Songs = new List<Song>()
            //        {
            //            new Song()
            //            {
            //                Genre = "Pop",
            //                Name = "Back",
            //                Artist = "Christina Aguilera",

            //            },
            //            new Song()
            //            {
            //                Genre = "Pop",
            //                Name = "Basics",
            //                Artist = "Christina Aguilera",
            //                //Year = new DateTime(2013,12,1)
            //            },
            //            new Song()
            //            {
            //                Genre = "Pop",
            //                Name = "Stronger",
            //                Artist = "Christina Aguilera",
            //                //Year = new DateTime(2013,12,1)
            //            },
            //            new Song()
            //            {
            //                Genre = "Pop",
            //                Name = "AddOrUpdateTest",
            //                Artist = "Christina Aguilera",
            //                //Year = new DateTime(2013,12,1)
            //            }
            //        }
            //   }            
            //};
            //var testDateTime = new Artist()
            //{
            //    Name = "Test BirthDay Format",
            //    Country = "USA",
            //    //BirthDay = new DateTime(2008, 3, 15)
            //};
            //var test = new Artist()
            //{
            //    Name = "latest",
            //    Country = "Test"
            //};
            //            Това ли искаш
            //string dateString;
            //        DateTime result;
            //        CultureInfo provider = CultureInfo.InvariantCulture;

            //        dateString = "01 01 2015";
            //        string[] format = new string[] { "dd/M/yyyy", "dd mm yyyy" };
            //        try
            //        {
            //            result = DateTime.ParseExact(dateString, format, provider, DateTimeStyles.None);
            //            Console.WriteLine("{0} converts to {1}.", dateString, result.ToString());
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("{0} is not in the correct format.", dateString);
            //        }
            // TODO add singers INNA
            //context.Artists.Add(testDateTime);
            //context.Artists.Add(christina);
            //context.Artists.Add(adam);
            //context.SaveChanges();
            }
        }
    }
