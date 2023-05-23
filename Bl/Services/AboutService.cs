using Bl.Interfaces;
using Domains;
using Bl.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class AboutService : IBusinessLayer<TbAbout>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly AboutRepository aboutRepository;

        public AboutService(IUnitOfWork _unitOfWork, AboutRepository _aboutRepository)
        {
            unitOfWork = _unitOfWork;
            aboutRepository = _aboutRepository;
        }
        #endregion

        #region Delete about
        bool IBusinessLayer<TbAbout>.Delete(int id)
        {
            try
            {

                var about = ((IBusinessLayer<TbAbout>)this).GetById(id);
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

        #region Get All abouts
        List<TbAbout> IBusinessLayer<TbAbout>.GetAll()
        {
            try
            {
                return (List<TbAbout>)aboutRepository.Get_All();
                

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
                var Objabout = aboutRepository.FindBy(a => a.AboutID == id && a.AboutCurrentState == 1).FirstOrDefault();
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
                    aboutRepository.Add(table);
                }
                else
                {
                    aboutRepository.Edit(table);
                }

                unitOfWork.Commit();
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
