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
    public class MainAdRepository : IGenericRepository<TbMainAd>
    {
        #region Dependency injection
        protected readonly GoldenDbContext context;
        public MainAdRepository(GoldenDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbMainAd entity)
        {
            context.Set<TbMainAd>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbMainAd entity)
        {
            context.Set<TbMainAd>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbMainAd entity)
        {
            context.Set<TbMainAd>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbMainAd> FindBy(Expression<Func<TbMainAd, bool>> predicate)
        {

            return context.Set<TbMainAd>().Where(predicate);

        }
        #endregion

        #region GetAll
        public List<TbMainAd> Get_All()
        {
            return context.Set<TbMainAd>()
                .Where(a => a.MainAdCurrentState == 1).ToList();

        }
        #endregion
    }
}
