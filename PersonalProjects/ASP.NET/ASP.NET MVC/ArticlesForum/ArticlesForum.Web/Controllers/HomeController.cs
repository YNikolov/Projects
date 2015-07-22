namespace ArticlesForum.Web.Controllers
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using ArticlesForum.Data;
    using ArticlesForum.Web.Models.Home;    
    using ArticlesForum.Web.Infrastructure.Mapping;
    using ArticlesForum.Web.Infrastructure.Services;
    using ArticlesForum.Web.Infrastructure.Services.Contracts;

    public class HomeController : BaseController
    {
        private IHomeServices homeServices;

        public HomeController(IArticlesForumData data, IHomeServices homeServices)
            : base(data)
        {
            this.homeServices = homeServices;
        }
        public ActionResult Index()
        {
            
            return View(this.homeServices.GetIndexViewModel(6));
        }
            
        public ActionResult Error()
        {            
            return View();
        }
    }
}