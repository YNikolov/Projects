
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

    public class Song : ICover
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime Year { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }

        //public string Artist { get; set; }

        //[ForeignKey("Album")]
        public int? AlbumId { get; set; }
        public virtual Album Album { get; set; }
        
    }
}
