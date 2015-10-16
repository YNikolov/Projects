namespace LaptopListingSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Laptop
    {
        private ICollection<Vote> votes;
        private ICollection<Comment> comments;

        public Laptop()
        {
            this.votes = new HashSet<Vote>();
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        public int ManufacturerId { get; set; }
     
        public virtual Manufacturer Manufacturer { get; set; }
        
        [Required]
        public string Model { get; set; }

        [Required]
        public double ScreenSize { get; set; }

        [Required]
        public int HardDisk { get; set; }

        [Required]
        public int Ram { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }

        public double? Weight { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Vote> Votes
        {
            get
            {
                return this.votes;
            }
            set
            {
                this.votes = value;
            }
        }

        public virtual ICollection<Comment> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }

    }
}
