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
    public class NewsRepository : IGenericRepository<TbNews>
    {
        #region Dependency injection
        protected readonly GoldenDbContext context;
        public NewsRepository(GoldenDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbNews entity)
        {
            context.Set<TbNews>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbNews entity)
        {
            context.Set<TbNews>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbNews entity)
        {
            context.Set<TbNews>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbNews> FindBy(Expression<Func<TbNews, bool>> predicate)
        {

            return context.Set<TbNews>().Where(predicate);

        }
        #endregion

        #region GetAll
        public List<TbNews> Get_All()
        {
            return context.Set<TbNews>().Where(a => a.NewsCurrentState == 1).ToList();
        }
        #endregion
    }
}
