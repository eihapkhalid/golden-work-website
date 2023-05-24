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
    public class ServiceService : IBusinessLayer<TbService>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<TbService> serviceRepository;

        public ServiceService(IUnitOfWork _unitOfWork, IGenericRepository<TbService> _serviceRepository)
        {
            unitOfWork = _unitOfWork;
            serviceRepository = _serviceRepository;
        }
        #endregion

        #region Delete Service
        bool IBusinessLayer<TbService>.Delete(int id)
        {
            try
            {

                var service = ((IBusinessLayer<TbService>)this).GetById(id);
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
                return (List<TbService>)serviceRepository.Get_All();
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
                var ObjService = serviceRepository.FindBy(a => a.ServiceID == id && a.ServiceCurrentState == 1).FirstOrDefault();
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
                    serviceRepository.Add(table);
                }
                else
                {
                    serviceRepository.Edit(table);
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
