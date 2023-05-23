using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class AboutService : IBusinessLayer<TbAbout>
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

        #region Delete about
        bool IBusinessLayer<TbAbout>.Delete(int id)
        {
            try
            {

                var about = GetById(id);
                about.AboutCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All aboutS
        List<TbAbout> IBusinessLayer<TbAbout>.GetAll()
        {
            try
            {
                var lstabout = context.TbAbout.Where(a => a.AboutCurrentState == 1).ToList();
                return lstabout;
            }
            catch
            {
                return new List<TbAbout>();
            }
        }
        #endregion

        #region Get about ById
        TbAbout IBusinessLayer<TbAbout>.GetById(int id)
        {
            try
            {
                var Objabout = context.TbAbout.Where(a => a.AboutID == id && a.AboutCurrentState == 1).FirstOrDefault();
                return Objabout;
            }
            catch
            {
                return new TbAbout();
            }
        }
        #endregion

        #region Save about in DataBase
        bool IBusinessLayer<TbAbout>.Save(TbAbout table)
        {
            try
            {
                if (table.AboutID == 0)
                {
                    table.AboutCurrentState = 1;
                    context.TbAbout.Add(table);
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
