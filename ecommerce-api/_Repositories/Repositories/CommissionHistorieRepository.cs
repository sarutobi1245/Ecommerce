using ecommerce_api._Repositories.Interface;
using ecommerce_api.Data;
using ecommerce_api.Models;

namespace ecommerce_api._Repositories.Repositories
{
    public class CommissionHistorieRepository : ECRepository<Commission_history>, ICommissionHistorieRepository
    {
        public CommissionHistorieRepository(DataContext context) : base(context)
        {
        }
    }
}