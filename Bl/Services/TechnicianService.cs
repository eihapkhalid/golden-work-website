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
    public class TechnicianService : IBusinessLayer<TbTechnician>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<TbTechnician> technicianRepository;

        public TechnicianService(IUnitOfWork _unitOfWork, IGenericRepository<TbTechnician> _technicianRepository)
        {
            unitOfWork = _unitOfWork;
            technicianRepository = _technicianRepository;
        }
        #endregion

        #region Delete Technician
        bool IBusinessLayer<TbTechnician>.Delete(int id)
        {
            try
            {

                var technician = ((IBusinessLayer<TbTechnician>)this).GetById(id);
                technician.TechnicianCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All Technician
        List<TbTechnician> IBusinessLayer<TbTechnician>.GetAll()
        {
            try
            {
                return (List<TbTechnician>)technicianRepository.Get_All();
            }
            catch
            {
                return new List<TbTechnician>();
            }
        }
        #endregion

        #region Get Technician ById
        TbTechnician IBusinessLayer<TbTechnician>.GetById(int id)
        {
            try
            {
                var ObjTechnician = technicianRepository.FindBy(a => a.TechnicianID == id && a.TechnicianCurrentState == 1).FirstOrDefault();
                return ObjTechnician;
            }
            catch
            {
                return new TbTechnician();
            }
        }
        #endregion

        #region Save Technician in DataBase
        bool IBusinessLayer<TbTechnician>.Save(TbTechnician table)
        {
            try
            {
                if (table.TechnicianID == 0)
                {
                    table.TechnicianCurrentState = 1;
                    technicianRepository.Add(table);
                }
                else
                {
                    technicianRepository.Edit(table);
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
