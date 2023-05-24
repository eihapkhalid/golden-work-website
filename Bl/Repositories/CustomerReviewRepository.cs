using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Repositories
{
    public class CustomerReviewRepository : IGenericRepository<TbCustomerReview>
    {
        #region Dependency injection
        protected readonly GoldenDbContext context;
        public CustomerReviewRepository(GoldenDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbCustomerReview entity)
        {
            context.Set<TbCustomerReview>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbCustomerReview entity)
        {
            context.Set<TbCustomerReview>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbCustomerReview entity)
        {
            context.Set<TbCustomerReview>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbCustomerReview> FindBy(Expression<Func<TbCustomerReview, bool>> predicate)
        {

            return context.Set<TbCustomerReview>().Where(predicate);

        }
        #endregion

        #region GetAll
        public IQueryable<TbCustomerReview> Get_All()
        {
            return context.Set<TbCustomerReview>().Where(a => a.CustomerReviewCurrentState == 1) ;
        }
        #endregion
    }
}
