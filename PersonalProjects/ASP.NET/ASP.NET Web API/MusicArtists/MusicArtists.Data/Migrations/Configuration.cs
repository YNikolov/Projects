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
            this.SeedArtists(context);
            //this.SeedAlbums(context);
            //this.SeedSongs(context);
        }

        private void SeedArtists(IMusicArtistsDbContext context)
        {
            if (context.Artists.Any())
            {
                return;
            }
            var christina = new Artist()
            {
                Name = "Christina Aguilera",
                Country = "USA",
                
            };
            christina.Albums = new List<Album>()
            {
               new Album() 
               {
                    Name = "Dirrty",
                    Genre = "Pop",
                    Producer = "Christina Aguilera",                    
                    Songs = new List<Song>()
                    {
                        new Song()
                        {
                            Genre = "Pop",
                            Name = "Dirrty"                            
                        }
                    }
               },
               new Album() 
               {
                    Name = "Stripped",
                    Genre = "Pop",
                    Producer = "Christina Aguilera",                    
                    Songs = new List<Song>()
                    {
                        new Song()
                        {
                            Genre = "Pop",
                            Name = "Stripped"                            
                        },
                        new Song()
                        {
                            Genre = "Pop",
                            Name = "Fighter"                            
                        },
                        new Song()
                        {
                            Genre = "Pop",
                            Name = "Beautyfull"
                        }
                    }
               },
               new Album() 
               {
                    Name = "BackToBasics",
                    Genre = "Pop",
                    Producer = "Christina Aguilera",
                    Songs = new List<Song>()
                    {
                        new Song()
                        {
                            Genre = "Pop",
                            Name = "Back"
                        },
                        new Song()
                        {
                            Genre = "Pop",
                            Name = "Basics"
                        },
                        new Song()
                        {
                            Genre = "Pop",
                            Name = "Stronger"
                        },
                        new Song()
                        {
                            Genre = "Pop",
                            Name = "AddOrUpdateTest"
                        }
                    }
               }            
            };
            
                        
            // TODO add singers INNA
            
            
            context.Artists.Add(christina);
            //context.Artists.Add(adam);
            context.SaveChanges();
            }
        }
    }
