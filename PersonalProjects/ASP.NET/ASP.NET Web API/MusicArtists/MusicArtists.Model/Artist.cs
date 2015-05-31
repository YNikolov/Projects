
namespace MusicArtists.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MusicArtists.Model.Interfaces;
    using System.ComponentModel.DataAnnotations;
    public class Artist : ICover
    {
        private ICollection<Album> albums;

        public Artist()
        {
            this.albums = new HashSet<Album>();
        }
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string Name { get; set; }
        
        
        //[DataType(DataType.Date)]
        //[DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{dddd, dd MMMM yyyy}")]
       // public DateTime BirthDay { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        
        public virtual ICollection<Album> Albums
        {
            get
            {
                return this.albums;
            }
            set
            {
                this.albums = value;
            }
        }

    }
}
