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
    public class ServiceRepository : IGenericRepository<TbService>
    {
        #region Dependency injection
        protected readonly GoldenWorkDbContext context;
        public ServiceRepository(GoldenWorkDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbService entity)
        {
            context.Set<TbService>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbService entity)
        {
            context.Set<TbService>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbService entity)
        {
            context.Set<TbService>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbService> FindBy(Expression<Func<TbService, bool>> predicate)
        {

            return context.Set<TbService>().Where(predicate);

        }
        #endregion

        #region GetAll
        public IQueryable<TbService> Get_All()
        {
            return context.Set<TbService>().Where(a => a.AboutCurrentState == 1).ToList(); ;
        }
        #endregion
    
    }
}
