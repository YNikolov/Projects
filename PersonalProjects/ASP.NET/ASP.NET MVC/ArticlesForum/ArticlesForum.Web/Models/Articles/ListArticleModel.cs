using ArticlesForum.Models;
using ArticlesForum.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticlesForum.Web.Models.Articles
{
    public class ListArticleModel : IMapFrom<Article>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string ArticleTitle { get; set; }

        public string CategoryName { get; set; }

        public string AuthorUserName { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Article, ListArticleModel>()
                            .ForMember(m => m.ArticleTitle, opt => opt.MapFrom(a => a.Title))
                            .ForMember(m => m.CategoryName, opt => opt.MapFrom(c => c.Category.Name))
                            .ForMember(m => m.AuthorUserName, opt => opt.MapFrom(u => u.Author.UserName))
                            
                            .ReverseMap();
        }
    }
}