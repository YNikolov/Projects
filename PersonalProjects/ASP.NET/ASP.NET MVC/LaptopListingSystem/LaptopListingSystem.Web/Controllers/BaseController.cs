
namespace LaptopListingSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using LaptopListingSystem.Data;
using LaptopListingSystem.Models;
    using System.Web.Routing;
    public class BaseController : Controller
    {
        protected ILaptopListingSystemData Data { get; private set; }

        protected User UserProfile { get; private set; }

        public BaseController(ILaptopListingSystemData data)
        {
            this.Data = data;
        }

        // TODO identity
        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            //this.UserProfile = this.Data.Users.All()
            //    .Where(u => u.UserName == requestContext.HttpContext.User.Identity.Name)
            //    .FirstOrDefault();

            return base.BeginExecute(requestContext, callback, state);
        }

    }
}