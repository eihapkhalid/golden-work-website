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
    public class CustomerRepository : IGenericRepository<TbCustomer>
    {
        #region Dependency injection
        protected readonly GoldenWorkDbContext context;
        public CustomerRepository(GoldenWorkDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbCustomer entity)
        {
            context.Set<TbCustomer>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbCustomer entity)
        {
            context.Set<TbCustomer>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbCustomer entity)
        {
            context.Set<TbCustomer>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbCustomer> FindBy(Expression<Func<TbCustomer, bool>> predicate)
        {

            return context.Set<TbCustomer>().Where(predicate);

        }
        #endregion

        #region GetAll
        public IQueryable<TbCustomer> Get_All()
        {
            return context.Set<TbCustomer>().Where(a => a.AboutCurrentState == 1).ToList(); ;
        }
        #endregion
    }
}
