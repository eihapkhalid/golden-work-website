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
    public class BookingRepository : IGenericRepository<TbBooking>
    {
        #region Dependency injection
        protected readonly GoldenDbContext context;
        public BookingRepository(GoldenDbContext _context)
        {
            context = _context;
        }
        #endregion

        #region Add
        public void Add(TbBooking entity)
        {
            context.Set<TbBooking>().Add(entity);
        }
        #endregion

        #region Delete
        public void Delete(TbBooking entity)
        {
            context.Set<TbBooking>().Remove(entity);
        }
        #endregion

        #region Edit
        public void Edit(TbBooking entity)
        {
            context.Set<TbBooking>().Update(entity);
        }
        #endregion

        #region FindBy
        public IQueryable<TbBooking> FindBy(Expression<Func<TbBooking, bool>> predicate)
        {
            return context.Set<TbBooking>().Where(predicate);
        }
        #endregion

        #region GetAll
        public IQueryable<TbBooking> Get_All()
        {
            return context.Set<TbBooking>().Where(a => a.BookingCurrentState == 1);
        }
        #endregion
    }
}
