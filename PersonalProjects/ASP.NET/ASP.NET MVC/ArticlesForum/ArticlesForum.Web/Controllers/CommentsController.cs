namespace ArticlesForum.Web.Controllers
{
    using System.Web;
    using System.Web.Mvc;
    using AutoMapper;

    using ArticlesForum.Data;
    using ArticlesForum.Web.Models.Comments;
    using ArticlesForum.Models;

    public class CommentsController : BaseController
    {
        // GET: Comments
        public CommentsController(IArticlesForumData data)
            : base(data)
        {

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostComment(PostCommentModel comment)
        {
            if (comment != null && ModelState.IsValid)
            {
                var dbComment = Mapper.Map<Comment>(comment);
                dbComment.Author = this.UserProfile;
                var article = this.Data.Articles.GetById(comment.ArticleId);
                if (article == null)
                {
                    throw new HttpException(404, "Article was not found!");
                }
                
                article.Comments.Add(dbComment);
                this.Data.SaveChanges();

                var viewModel = Mapper.Map<CommentViewModel>(dbComment);

                return PartialView("_CommentPartial", viewModel);
            }

            throw new HttpException(400, "Invalid Comment");
        }
    }
}