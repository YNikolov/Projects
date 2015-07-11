
namespace ArticlesForum.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Article
    {
        private ICollection<Comment> comments { get; set; }

        public Article()
        {
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Comment> Comments
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
