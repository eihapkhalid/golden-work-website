using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class CustomerService : IBusinessLayer<TbCustomer>
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

        #region Delete customer
        bool IBusinessLayer<TbCustomer>.Delete(int id)
        {
            try
            {

                var customer = GetById(id);
                customer.CustomerCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All customer
        List<TbCustomer> IBusinessLayer<TbCustomer>.GetAll()
        {
            try
            {
                var lstcustomer = context.TbCustomer.Where(a => a.CustomerCurrentState == 1).ToList();
                return lstcustomer;
            }
            catch
            {
                return new List<TbCustomer>();
            }
        }
        #endregion

        #region Get customer ById
        TbCustomer IBusinessLayer<TbCustomer>.GetById(int id)
        {
            try
            {
                var Objcustomer = context.TbCustomer.Where(a => a.CustomerID == id && a.CustomerCurrentState == 1).FirstOrDefault();
                return Objcustomer;
            }
            catch
            {
                return new TbCustomer();
            }
        }
        #endregion

        #region Save customer in DataBase
        bool IBusinessLayer<TbCustomer>.Save(TbCustomer table)
        {
            try
            {
                if (table.CustomerID == 0)
                {
                    table.CustomerCurrentState = 1;
                    context.TbCustomer.Add(table);
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
