using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class ServiceService : IBusinessLayer<TbService>
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

        #region Delete Service
        bool IBusinessLayer<TbService>.Delete(int id)
        {
            try
            {

                var service = GetById(id);
                service.ServiceCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All Services
        List<TbService> IBusinessLayer<TbService>.GetAll()
        {
            try
            {
                var lstService = context.TbService.Where(a => a.ServiceCurrentState == 1).ToList();
                return lstService;
            }
            catch
            {
                return new List<TbService>();
            }
        }
        #endregion

        #region Get Service ById
        TbService IBusinessLayer<TbService>.GetById(int id)
        {
            try
            {
                var ObjService = context.TbService.Where(a => a.TechnicianID == id && a.ServiceCurrentState == 1).FirstOrDefault();
                return ObjService;
            }
            catch
            {
                return new TbService();
            }
        }
        #endregion

        #region Save Service in DataBase
        bool IBusinessLayer<TbService>.Save(TbService table)
        {
            try
            {
                if (table.ServiceID == 0)
                {
                    table.ServiceCurrentState = 1;
                    context.TbService.Add(table);
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
