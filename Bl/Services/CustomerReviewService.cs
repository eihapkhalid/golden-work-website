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
    public class CustomerReviewService :IBusinessLayer<TbCustomerReview>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<TbCustomerReview> customerReviewRepository;

        public CustomerReviewService(IUnitOfWork _unitOfWork, IGenericRepository<TbCustomerReview> _customerReviewRepository)
        {
            unitOfWork = _unitOfWork;
            customerReviewRepository = _customerReviewRepository;
        }
        #endregion

        #region Delete customerReview
        bool IBusinessLayer<TbCustomerReview>.Delete(int id)
        {
            try
            {

                var customerReview = ((IBusinessLayer<TbCustomerReview>)this).GetById(id);
                customerReview.CustomerReviewCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All customerReview
        List<TbCustomerReview> IBusinessLayer<TbCustomerReview>.GetAll()
        {
            try
            {
                return (List<TbCustomerReview>)customerReviewRepository.Get_All();
            }
            catch
            {
                return new List<TbCustomerReview>();
            }
        }
        #endregion

        #region Get customerReview ById
        TbCustomerReview IBusinessLayer<TbCustomerReview>.GetById(int id)
        {
            try
            {
                var ObjcustomerReview = customerReviewRepository.FindBy(a => a.CustomerReviewID == id && a.CustomerReviewCurrentState == 1).FirstOrDefault();
                return ObjcustomerReview;
            }
            catch
            {
                return new TbCustomerReview();
            }
        }
        #endregion

        #region Save customerReview in DataBase
        bool IBusinessLayer<TbCustomerReview>.Save(TbCustomerReview table)
        {
            try
            {
                if (table.CustomerReviewID == 0)
                {
                    table.CustomerReviewCurrentState = 1;
                    customerReviewRepository.Add(table);
                }
                else
                {
                    customerReviewRepository.Edit(table);
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
