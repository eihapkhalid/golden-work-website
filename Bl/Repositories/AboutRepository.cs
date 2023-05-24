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
    public class AboutRepository  :IGenericRepository<TbAbout>
    {
        #region Dependency injection
        protected readonly GoldenDbContext context;
        public AboutRepository(GoldenDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbAbout entity)
        {
            context.Set<TbAbout>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbAbout entity)
        {
            context.Set<TbAbout>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbAbout entity)
        {
            context.Set<TbAbout>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbAbout> FindBy(Expression<Func<TbAbout, bool>> predicate)
        {
            
            return context.Set<TbAbout>().Where(predicate);

        }
        #endregion

        #region GetAll
        public IQueryable<TbAbout> Get_All()
        {
            return (IQueryable<TbAbout>)context.Set<TbAbout>().Where(a => a.AboutCurrentState == 1);
        }
        #endregion
    }
}
