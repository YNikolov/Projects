namespace MusicArtists.Services.Models
{
    using System;
    using System.Linq.Expressions;
    using MusicArtists.Model;

    using System.ComponentModel.DataAnnotations;
    public class ArtistModel
    {
        public static Expression<Func<Artist, ArtistModel>> FromArtist
        {
            get
            {
                return a => new ArtistModel
                {
                    ArtistId = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    Country = a.Country

                };
            }
        }

        public int ArtistId { get; set; }
        
        public string Name { get; set; }
        
        public string ImageUrl { get; set; }
     
        public string Country { get; set; }
     
    }
}