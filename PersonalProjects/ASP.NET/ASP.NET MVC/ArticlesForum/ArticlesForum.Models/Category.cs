﻿namespace ArticlesForum.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Category
    {        
        private ICollection<Article> articles;

        public Category()
        {
            this.articles = new HashSet<Article>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public ICollection<Article> Articles
        {
            get 
            {
                return this.articles;
            }
            set
            {
                this.articles = value;
            }
        }
    }
}
