namespace ArticlesForum.Web.Infrastructure.Services
{
    using ArticlesForum.Data;

    public abstract class BaseServices
    {
        protected IArticlesForumData Data { get; private set; }

        public BaseServices(IArticlesForumData data)
        {
            this.Data = data;
        }
    }
}