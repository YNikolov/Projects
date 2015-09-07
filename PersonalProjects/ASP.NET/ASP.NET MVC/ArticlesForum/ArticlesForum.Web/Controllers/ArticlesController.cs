namespace ArticlesForum.Web.Controllers
{
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper;
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
             
        public ActionResult Add()
        {
            var addArticleViewModel = new AddArticleViewModel
            {
                Categories = this.Data.Categories
                .All()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
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
            
            article.Categories = this.Data.Categories
                .All()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                });
            
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
    }
}