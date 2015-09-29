namespace ArticlesForum.Web.Areas.Administration.Controllers
{
    using System.Collections;
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using ArticlesForum.Data;
    using ArticlesForum.Models;
    using ArticlesForum.Web.Areas.Administration.Controllers;
    using ArticlesForum.Web.Infrastructure.Caching;

    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;

    using Model = ArticlesForum.Models.Category;
    using ViewModel = ArticlesForum.Web.Areas.Administration.Models.Categories.CategoryModel;

    public class CategoriesController : KendoGridAdministrationController
    {
        private readonly ICacheService service;

        public CategoriesController(IArticlesForumData data, ICacheService service)
            : base(data)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        protected override IEnumerable GetData()
        {
            return this.Data
                .Categories
                .All()
                .Project()
                .To<ViewModel>();
        }

        protected override T GetById<T>(object id)
        {
            return this.Data.Categories.GetById(id) as T;
        }

        [HttpPost]
        public ActionResult Create([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            var dbModel = base.Create<Model>(model);
            if (dbModel != null) model.Id = dbModel.Id;
            this.ClearCategoryCache();
            return this.GridOperation(model, request);
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            base.Update<Model, ViewModel>(model, model.Id);
            this.ClearCategoryCache();
            return this.GridOperation(model, request);
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                var category = this.Data.Categories.GetById(model.Id.Value);

                foreach (var articleId in category.Articles.Select(t => t.Id).ToList())
                {
                    var comments = this.Data
                        .Comments
                        .All()
                        .Where(c => c.ArticleId == articleId)
                        .Select(c => c.Id)
                        .ToList();

                    foreach (var commentId in comments)
                    {
                        this.Data.Comments.Delete(commentId);
                    }

                    this.Data.SaveChanges();

                    this.Data.Articles.Delete(articleId);                
                }

                this.Data.SaveChanges();

                this.Data.Categories.Delete(category);
                this.Data.SaveChanges();
            }

            this.ClearCategoryCache();
            return this.GridOperation(model, request);
        }

        private void ClearCategoryCache()
        {
            this.service.Clear("categories");
        }
    }
}