
namespace MusicArtists.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    
    using MusicArtists.Data.Interfaces;
    using MusicArtists.Model;
    using MusicArtists.Data.Migrations;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class MusicArtistsDbContext : DbContext, IMusicArtistsDbContext
    {
        public MusicArtistsDbContext()
            : base("MusicArtist")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicArtistsDbContext, Configuration>());
        }
        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Album> Albums { get; set; }


        public virtual IDbSet<Song> Songs { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<Album>()
                .HasOptional(a => a.Artist)
                ////.WithMany(a => a.Albums)
                .WithOptionalDependent()
                //.WithOptionalPrincipal()
                ////.HasForeignKey(a => a.ArtistId)
                .WillCascadeOnDelete(true);
        }
    }
}
