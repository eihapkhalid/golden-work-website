using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class customerReviewReviewService:IBusinessLayer<TbCustomerReview>
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

        #region Delete customerReview
        bool IBusinessLayer<TbCustomerReview>.Delete(int id)
        {
            try
            {

                var customerReview = GetById(id);
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
                var lstcustomerReview = context.TbCustomerReview.Where(a => a.CustomerReviewCurrentState == 1).ToList();
                return lstcustomerReview;
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
                var ObjcustomerReview = context.TbCustomerReview.Where(a => a.CustomerReviewID == id && a.CustomerReviewCurrentState == 1).FirstOrDefault();
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
                    context.TbCustomerReview.Add(table);
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
