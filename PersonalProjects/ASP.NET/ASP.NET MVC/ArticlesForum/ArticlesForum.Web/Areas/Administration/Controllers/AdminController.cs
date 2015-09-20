namespace ArticlesForum.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using ArticlesForum.Common;
    using ArticlesForum.Data;
    using ArticlesForum.Web.Controllers;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public abstract class AdminController : BaseController
    {
        // GET: Administration/Admin
        public AdminController(IArticlesForumData data)
            : base(data)
        {
            
        }
    }
}