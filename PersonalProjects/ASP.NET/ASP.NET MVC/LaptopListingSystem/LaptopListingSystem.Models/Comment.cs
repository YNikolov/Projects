namespace LaptopListingSystem.Models
{

    public class Comment
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int LaptopId { get; set; }

        public virtual Laptop Laptop { get; set; }

        public string Content { get; set; }                        
    }
}
