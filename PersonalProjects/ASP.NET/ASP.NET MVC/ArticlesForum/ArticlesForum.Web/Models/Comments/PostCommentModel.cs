namespace ArticlesForum.Web.Models.Comments
{
    using AutoMapper;

    using System.ComponentModel.DataAnnotations;
    using ArticlesForum.Web.Infrastructure.Mapping;
    using ArticlesForum.Models;


    public class PostCommentModel : IMapFrom<Comment>
    {
        public PostCommentModel()
        { }

        public PostCommentModel(int articleId)
        {
            this.ArticleId = articleId;

        }
        public int ArticleId { get; set; }

        [UIHint("MultiLineText")]
        public string Content { get; set; } 
    }
}