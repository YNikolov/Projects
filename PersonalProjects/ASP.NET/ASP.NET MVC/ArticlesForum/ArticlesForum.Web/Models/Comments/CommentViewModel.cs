

namespace ArticlesForum.Web.Models.Comments
{
    using System.Web;

    using ArticlesForum.Models;
    using ArticlesForum.Web.Infrastructure.Mapping;
    using AutoMapper;
    
    public class CommentViewModel : IMapFrom<Comment> ,IHaveCustomMappings
    {
       
        public int Id { get; set; }

        public string Content { get; set; }               

        public string Author { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(m => m.Author, opt => opt.MapFrom(a => a.Author.UserName))
                .ForMember(m => m.Content, opt => opt.MapFrom(c => c.Content))
                .ReverseMap();
        }
    }
}