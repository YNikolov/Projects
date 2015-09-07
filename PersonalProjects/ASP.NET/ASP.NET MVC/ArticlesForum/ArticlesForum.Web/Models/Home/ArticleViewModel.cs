namespace ArticlesForum.Web.Models.Home
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using AutoMapper;

    using ArticlesForum.Models;
    using ArticlesForum.Web.Infrastructure.Mapping;
    
    public class ArticleViewModel : IMapFrom<Article>, IHaveCustomMappings
    {
        public int Id { get; set; }
        
        public string ArticleTitle { get; set; }
        
        public string CategoryName { get; set; }
        
        public string AuthorUserName { get; set; }

        public int NumbersOfComments { get; set; }

        public string ImageUrl { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Article, ArticleViewModel>()
                .ForMember(m => m.ArticleTitle, opt => opt.MapFrom(a => a.Title))
                .ForMember(m => m.CategoryName, opt => opt.MapFrom(c => c.Category.Name))
                .ForMember(m => m.AuthorUserName, opt => opt.MapFrom(u => u.Author.UserName))
                .ForMember(m => m.NumbersOfComments, opt => opt.MapFrom(n => n.Comments.Count()))                
                .ReverseMap();
        }
    }
}