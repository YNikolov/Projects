namespace ArticlesForum.Web.Models.Articles
{
    using System.Collections.Generic;
    using System.Web;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using ArticlesForum.Models;
    using ArticlesForum.Web.Infrastructure.Mapping;    
    using ArticlesForum.Web.Models.Comments;

    public class ArticleDetailsViewModel: IMapFrom<Article>, IHaveCustomMappings
    {        
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string AuthorName { get; set; }

        public string CategoryName { get; set; }

        public int? ImageId { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
               
        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Article, ArticleDetailsViewModel>()
                .ForMember(m => m.AuthorName, opt => opt.MapFrom(a => a.Author.UserName))
                .ForMember(m => m.CategoryName, opt => opt.MapFrom(c => c.Category.Name))                
                .ReverseMap();
        }
    }
}