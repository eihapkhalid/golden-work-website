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
    public class UserRepository : IGenericRepository<TbUser>
    {
        #region Dependency injection
        protected readonly GoldenWorkDbContext context;
        public UserRepository(GoldenWorkDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbUser entity)
        {
            context.Set<TbUser>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbUser entity)
        {
            context.Set<TbUser>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbUser entity)
        {
            context.Set<TbUser>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbUser> FindBy(Expression<Func<TbUser, bool>> predicate)
        {

            return context.Set<TbUser>().Where(predicate);

        }
        #endregion

        #region GetAll
        public IQueryable<TbUser> Get_All()
        {
            return context.Set<TbUser>().Where(a => a.AboutCurrentState == 1).ToList(); ;
        }
        #endregion
    }
}
