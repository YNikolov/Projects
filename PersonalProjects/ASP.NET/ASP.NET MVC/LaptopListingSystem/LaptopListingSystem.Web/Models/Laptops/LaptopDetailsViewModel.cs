namespace LaptopListingSystem.Web.Models.Laptops
{
    using System.Collections.Generic;
    using LaptopListingSystem.Web.Models.Comments;

    public class LaptopDetailsViewModel
    {        
        public int Id { get; set; }
                
        public string Manufacturer { get; set; }
        
        public string Model { get; set; }
        
        public double ScreenSize { get; set; }
        
        public int HardDisk { get; set; }
        
        public int Ram { get; set; }
        
        public string Image { get; set; }
        
        public decimal Price { get; set; }

        public double? Weight { get; set; }

        public string Description { get; set; }

        public int Votes { get; set; }

        public bool UserVoteAuthorization { get; set; }

        public IEnumerable<CommentViewModel> Comments { get; set; }
    }
}