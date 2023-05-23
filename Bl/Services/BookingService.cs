using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class BookingService : IBusinessLayer<TbBooking>
    {
        #region define DbContext
        private GoldenWorkDbContext context;
        private readonly IUnitOfWork unitOfWork;
        public TechnicianService(GoldenWorkDbContext ctx, IUnitOfWork _unitOfWork)
        {
            context = ctx;
            unitOfWork = _unitOfWork;
        }
        #endregion

        #region Delete booking
        bool IBusinessLayer<TbBooking>.Delete(int id)
        {
            try
            {

                var booking = GetById(id);
                booking.BookingCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All bookingS
        List<TbBooking> IBusinessLayer<TbBooking>.GetAll()
        {
            try
            {
                var lstbooking = context.TbBooking.Where(a => a.BookingCurrentState == 1).ToList();
                return lstbooking;
            }
            catch
            {
                return new List<TbBooking>();
            }
        }
        #endregion

        #region Get booking ById
        TbBooking IBusinessLayer<TbBooking>.GetById(int id)
        {
            try
            {
                var Objbooking = context.TbBooking.Where(a => a.BookingID == id && a.BookingCurrentState == 1).FirstOrDefault();
                return Objbooking;
            }
            catch
            {
                return new TbBooking();
            }
        }
        #endregion

        #region Save booking in DataBase
        bool IBusinessLayer<TbBooking>.Save(TbBooking table)
        {
            try
            {
                if (table.BookingID == 0)
                {
                    table.BookingCurrentState = 1;
                    context.TbBooking.Add(table);
                }
                else
                {
                    context.Entry(table).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                unitOfWork.Commit(); //context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
