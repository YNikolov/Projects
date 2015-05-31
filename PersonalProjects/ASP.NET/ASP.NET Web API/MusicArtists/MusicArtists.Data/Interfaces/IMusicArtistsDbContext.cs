
namespace MusicArtists.Data.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;

    using MusicArtists.Model;
    using System.Data.Entity.Infrastructure;

    public interface IMusicArtistsDbContext
    {
        IDbSet<Artist> Artists { get; set; }
        IDbSet<Album> Albums { get; set; }
        IDbSet<Song> Songs { get; set; }
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        void SaveChanges();

    }
}
