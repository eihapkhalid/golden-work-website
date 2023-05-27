using Bl.Interfaces;
using Bl.Repositories;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class BookingService  : IBusinessLayer<TbBooking>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<TbBooking> bookingRepository;

        public BookingService(IUnitOfWork _unitOfWork, IGenericRepository<TbBooking> _bookingRepository)
        {
            unitOfWork = _unitOfWork;
            bookingRepository = _bookingRepository;
        }
        #endregion

        #region Delete booking
        bool IBusinessLayer<TbBooking>.Delete(int id)
        {
            try
            {

                var booking = ((IBusinessLayer<TbBooking>)this).GetById(id);
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
                return (List<TbBooking>)bookingRepository.Get_All();
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
                var Objbooking = bookingRepository.FindBy(a => a.BookingID == id && a.BookingCurrentState == 1).FirstOrDefault();
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
                    table.BookingEndDate = DateTime.Now;
                    table.BookingStartDate = DateTime.Now;
                    table.UserUpdateTime = DateTime.Now;
                    table.UserUpdateTimee = DateTime.Now;
                    bookingRepository.Add(table);
                }
                else
                {
                    bookingRepository.Edit(table);
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
