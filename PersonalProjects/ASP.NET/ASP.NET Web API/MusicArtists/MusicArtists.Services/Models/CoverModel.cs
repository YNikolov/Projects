
namespace MusicArtists.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;

    using MusicArtists.Model.Interfaces;
    public class CoverModel
    {
        public static Expression<Func<ICover, CoverModel>> FromCover
        {
            get
            {
                return c => new CoverModel
                {   
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                };
            }
        }
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int Id { get; set; }        
    }
}