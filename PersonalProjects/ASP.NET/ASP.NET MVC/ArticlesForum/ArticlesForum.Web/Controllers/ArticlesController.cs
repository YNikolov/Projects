namespace ArticlesForum.Web.Controllers
{
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;

    using ArticlesForum.Data;
    using ArticlesForum.Models;
    using ArticlesForum.Web.Models.Articles;
    using ArticlesForum.Web.Models.Comments;
    using ArticlesForum.Web.Infrastructure.Populators;


    public class ArticlesController : BaseController
    {
        private IDropDownListPopulator populator;
        public ArticlesController(IArticlesForumData data, IDropDownListPopulator populator)
            : base(data)
        {
            this.populator = populator;
        }
             
        [Authorize]
        public ActionResult All(int? categoryId)
        {
            return View(categoryId);
        }

        [Authorize]
        [HttpPost]
        public ActionResult ReadArticles([DataSourceRequest]DataSourceRequest request, int? categoryId)
        {
            var articlesQuery = this.Data.Articles.All();
                
                if(categoryId != null)
                {
                    articlesQuery = articlesQuery.Where(a => a.CategoryId == categoryId.Value);
                }
                
                var articles = articlesQuery                
                    .Project()
                    .To<ListArticleModel>();

            return Json(articles.ToDataSourceResult(request));
        }

        public ActionResult Add()
        {
            var addArticleViewModel = new AddArticleViewModel
            {
                Categories = this.populator.GetCategories()
            };
            return View(addArticleViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AddArticleViewModel article)
        {
            if (article != null && ModelState.IsValid)
            {
                var dbArticle = Mapper.Map<Article>(article);
                dbArticle.Author = this.UserProfile;
                if (article.UploadedImage != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        article.UploadedImage.InputStream.CopyTo(memory);
                        var content = memory.GetBuffer();

                        dbArticle.Image = new Image
                        {   //TODO Fix the picture content(showing <Binary data>) in the DB
                            Content = content,
                            FileExtension = article.UploadedImage.FileName.Split(new[] { '.'}).Last()
                        };
                    }
                }                            

                this.Data.Articles.Add(dbArticle);
                this.Data.SaveChanges();

                return RedirectToAction("All", "Articles");
            }

            article.Categories = this.populator.GetCategories();
            
            return View(article);
        }
        
        public ActionResult Details(int? id)
        {
            var article = this.Data
                .Articles
                .All()
                .Where(a => a.Id == id)
                .Project()
                .To<ArticleDetailsViewModel>()
                .FirstOrDefault();
                
            if (article == null)
            {
                throw new HttpException(404, "Article was not found!");
            }

            article.Comments = this.Data
                .Comments
                .All()
                .Where(c => c.ArticleId == article.Id)
                .Project()
                .To<CommentViewModel>()
                .ToList();

            return View(article);
        }

        public ActionResult Image(int id)
        {
            var image = this.Data
                .Images
                .GetById(id);

            if (image == null)
            {
                throw new HttpException(404, "Image not found");
            }

            return File(image.Content, "image/" + image.FileExtension);
        }

        public ActionResult GetCategories()
        {
            return Json(this.populator.GetCategories(), JsonRequestBehavior.AllowGet);
        }
    }
}








