namespace MusicArtists.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    using MusicArtists.Model;
    using System.ComponentModel.DataAnnotations.Schema;
    public class AlbumModel
    {
        public static Expression<Func<Album, AlbumModel>> FromAlbum
        {
            get
            {
                return al => new AlbumModel
                {
                    Id = al.Id,
                    Name = al.Name,
                    Genre = al.Genre,
                    Producer = al.Producer,                    
                    ImageUrl = al.ImageUrl,
                    ArtistId = al.ArtistId
                };
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime Year { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public string Producer { get; set; }
        public int? ArtistId { get; set; }
        
    }
}