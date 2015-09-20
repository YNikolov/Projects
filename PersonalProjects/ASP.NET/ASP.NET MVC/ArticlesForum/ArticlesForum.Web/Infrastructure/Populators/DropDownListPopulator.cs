namespace ArticlesForum.Web.Infrastructure.Populators
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.Linq;

    using ArticlesForum.Data;
    using ArticlesForum.Web.Infrastructure.Caching;

    public class DropDownListPopulator : IDropDownListPopulator
    {
        private IArticlesForumData data;
        private ICacheService cache;
        
        public DropDownListPopulator(IArticlesForumData data, ICacheService cache)
        {
            this.data = data;
            this.cache = cache;
        }

        public IEnumerable<SelectListItem> GetCategories()
        {
            var categories = this.cache.Get<IEnumerable<SelectListItem>>("categories",
               () =>
               {
                    return this.data.Categories
                        .All()
                        .Select(c => new SelectListItem
                        {
                            Value = c.Id.ToString(),
                            Text = c.Name
                        })
                        .ToList();
               });

            return categories;
        }
    }
}