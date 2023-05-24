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
    public class CustomerService : IBusinessLayer<TbCustomer>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<TbCustomer> customerRepository;

        public CustomerService(IUnitOfWork _unitOfWork, IGenericRepository<TbCustomer> _customerRepository)
        {
            unitOfWork = _unitOfWork;
            customerRepository = _customerRepository;
        }
        #endregion

        #region Delete customer
        bool IBusinessLayer<TbCustomer>.Delete(int id)
        {
            try
            {

                var customer = ((IBusinessLayer<TbCustomer>)this).GetById(id);
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
                return (List<TbCustomer>)customerRepository.Get_All();
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
                var Objcustomer = customerRepository.FindBy(a => a.CustomerID == id && a.CustomerCurrentState == 1).FirstOrDefault();
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
                    customerRepository.Add(table);
                }
                else
                {
                    customerRepository.Edit(table);
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
