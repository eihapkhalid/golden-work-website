using Bl.Interfaces;
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
        #region define DbContext
        private GoldenWorkDbContext context;
        private readonly IUnitOfWork unitOfWork;
        public TechnicianService(GoldenWorkDbContext ctx, IUnitOfWork _unitOfWork)
        {
            context = ctx;
            unitOfWork = _unitOfWork;
        }
        #endregion

        #region Delete Technician
        bool IBusinessLayer<TbTechnician>.Delete(int id)
        {
            try
            {

                var technician = GetById(id);
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
                var lstTechnicians = context.TbTechnician.Where(a => a.TechnicianCurrentState == 1).ToList();
                return lstTechnicians;
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
                var ObjTechnician = context.TbTechnician.Where(a => a.TechnicianID == id && a.TechnicianCurrentState == 1).FirstOrDefault();
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
                    context.TbTechnician.Add(table);
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
