namespace ArticlesForum.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {        
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }             

        public string AuthorId { get; set; }
        
        public virtual User Author { get; set; }

        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }

    }
}
