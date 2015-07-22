namespace ArticlesForum.Web.Controllers
{         
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using ArticlesForum.Data;
    using ArticlesForum.Models;
    using ArticlesForum.Web.Models.Articles;
    using ArticlesForum.Web.Models.Comments;

    public class ArticlesController : BaseController
    {
        public ArticlesController(IArticlesForumData data)
            : base(data)
        { }


        // GET: Articles
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
    }
}