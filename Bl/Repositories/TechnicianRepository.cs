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
    public class TechnicianRepository : IGenericRepository<TbTechnician>
    {
        #region Dependency injection
        protected readonly GoldenWorkDbContext context;
        public TechnicianRepository(GoldenWorkDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbTechnician entity)
        {
            context.Set<TbTechnician>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbTechnician entity)
        {
            context.Set<TbTechnician>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbTechnician entity)
        {
            context.Set<TbTechnician>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbTechnician> FindBy(Expression<Func<TbTechnician, bool>> predicate)
        {

            return context.Set<TbTechnician>().Where(predicate);

        }
        #endregion

        #region GetAll
        public IQueryable<TbTechnician> Get_All()
        {
            return context.Set<TbTechnician>().Where(a => a.AboutCurrentState == 1).ToList(); ;
        }
        #endregion
    }
}
