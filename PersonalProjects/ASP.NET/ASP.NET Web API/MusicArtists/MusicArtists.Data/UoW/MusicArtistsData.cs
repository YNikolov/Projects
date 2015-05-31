namespace MusicArtists.Data.UoW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;

    using MusicArtists.Data;
    using MusicArtists.Data.Repositories;
    using MusicArtists.Data.Interfaces;
    using MusicArtists.Model;

    public class MusicArtistsData : IMusicArtistsData
    {
        private IMusicArtistsDbContext context;
        private IDictionary<Type, object> repositories;

        public MusicArtistsData()
            : this(new MusicArtistsDbContext())
        { }

        public MusicArtistsData(IMusicArtistsDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Artist> Artists
        {
            get
            {
                return this.GetRepository<Artist>();
            }
            
        }

        public IRepository<Album> Albums
        {
            get
            {
                return this.GetRepository<Album>();
            }            
        }

        public IRepository<Song> Songs
        {
            get
            {
                return this.GetRepository<Song>();
            }
       }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(Repository<T>);
                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }
            return (IRepository<T>)this.repositories[typeOfModel];
        }
        
    }
}
