
namespace ArticlesForum.Web.Models.Articles
{
    using ArticlesForum.Web.Infrastructure.Mapping;
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    using ArticlesForum.Models;
    using System.ComponentModel.DataAnnotations;
    
    public class AddArticleViewModel : IMapFrom<Article>
    {       
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [UIHint("SingleLineText")]
        public string Title { get; set; }

        [StringLength(2000)]
        [UIHint("MultiLineText")]
        public string Content { get; set; }
              
        [Display(Name = "Category")]
        [UIHint("DropDownList")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        public HttpPostedFileBase UploadedImage { get; set; }

    }
}