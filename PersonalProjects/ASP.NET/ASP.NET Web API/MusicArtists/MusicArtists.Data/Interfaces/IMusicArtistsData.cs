namespace MusicArtists.Data.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MusicArtists.Model;
    using MusicArtists.Data.Repositories;
    public interface IMusicArtistsData
    {
        IRepository<Artist> Artists { get;}
        IRepository<Album> Albums { get;}
        IRepository<Song> Songs { get; }
        void SaveChanges();
    }
}
