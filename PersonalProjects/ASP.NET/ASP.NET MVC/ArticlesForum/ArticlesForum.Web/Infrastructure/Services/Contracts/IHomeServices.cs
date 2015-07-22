namespace ArticlesForum.Web.Infrastructure.Services
{
    using System.Collections.Generic;
    using System.Linq; 
    using ArticlesForum.Web.Models.Home;
    
    public interface IHomeServices
    {
        IList<ArticleViewModel> GetIndexViewModel(int numberOfArticles);       
    }
}
