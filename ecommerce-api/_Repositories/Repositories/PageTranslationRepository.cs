using ecommerce_api._Repositories.Interface;
using ecommerce_api.Data;
using ecommerce_api.Models;

namespace ecommerce_api._Repositories.Repositories
{
    public class PageTranslationRepository : ECRepository<Page_translation>, IPageTranslationRepository
    {
        public PageTranslationRepository(DataContext context) : base(context)
        {
        }
    }
}