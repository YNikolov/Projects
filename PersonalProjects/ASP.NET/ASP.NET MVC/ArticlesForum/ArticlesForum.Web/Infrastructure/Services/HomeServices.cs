
namespace ArticlesForum.Web.Infrastructure.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using AutoMapper.QueryableExtensions;

    using ArticlesForum.Data;
    using ArticlesForum.Web.Models.Home;

    public class HomeServices : BaseServices, IHomeServices
    {
        public HomeServices(IArticlesForumData data)
            : base(data)
        { }

        public IList<ArticleViewModel> GetIndexViewModel(int numberOfArticles)
        {
            var indexViewModel = this.Data
                .Articles
                .All()
                .OrderBy(a => a.Comments.Count())
                .Take(numberOfArticles)
                .Project()
                .To<ArticleViewModel>()
                .ToList();
            
            return indexViewModel;
        }
    }
}