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
    public class ContactRepository : IGenericRepository<TbContact>
    {
        #region Dependency injection
        protected readonly GoldenDbContext context;
        public ContactRepository(GoldenDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbContact entity)
        {
            context.Set<TbContact>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbContact entity)
        {
            context.Set<TbContact>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbContact entity)
        {
            context.Set<TbContact>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbContact> FindBy(Expression<Func<TbContact, bool>> predicate)
        {

            return context.Set<TbContact>().Where(predicate);

        }
        #endregion

        #region GetAll
        public List<TbContact> Get_All()
        {
            return context.Set<TbContact>().Where(a => a.ContactCurrentState == 1).ToList();
        }
        #endregion
    }
}
