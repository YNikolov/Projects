
namespace MusicArtists.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    
    using System.ComponentModel.DataAnnotations.Schema;

    using MusicArtists.Model.Interfaces;
    
    public class Album : ICover
    {
        private ICollection<Song> songs;

        public Album()
        {
            this.songs = new HashSet<Song>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime Year { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public string Producer { get; set; }

        //[Editable(true)]                        //  TODO not working find another solution
        public int? ArtistId { get; set; }

//        [Editable(true)]                        //  TODO not working find another solution
        public virtual Artist Artist { get; set; }
        
        public virtual ICollection<Song> Songs {
            get
            {
                return this.songs;
            }
            set
            {
                this.songs = value;
            }
        }
        
    }
}
