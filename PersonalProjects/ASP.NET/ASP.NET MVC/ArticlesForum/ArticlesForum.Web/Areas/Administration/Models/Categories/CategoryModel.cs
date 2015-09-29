namespace ArticlesForum.Web.Areas.Administration.Models.Categories
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using ArticlesForum.Models;
    using ArticlesForum.Web.Infrastructure.Mapping;

    public class CategoryModel : IMapFrom<Category>
    {
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        [Required]
        [UIHint("String")]
        public string Name { get; set; }
    }
}