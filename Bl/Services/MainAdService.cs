using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class MainAdService : IBusinessLayer<TbMainAd>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<TbMainAd> mainAdRepository;

        public MainAdService(IUnitOfWork _unitOfWork, IGenericRepository<TbMainAd> _mainAdRepository)
        {
            unitOfWork = _unitOfWork;
            mainAdRepository = _mainAdRepository;
        }
        #endregion

        #region Delete mainAd
        bool IBusinessLayer<TbMainAd>.Delete(int id)
        {
            try
            {

                var mainAd = ((IBusinessLayer<TbMainAd>)this).GetById(id);
                mainAd.MainAdCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All mainAds
        List<TbMainAd> IBusinessLayer<TbMainAd>.GetAll()
        {
            try
            {
                return (List<TbMainAd>)mainAdRepository.Get_All();
            }
            catch
            {
                return new List<TbMainAd>();
            }
        }
        #endregion

        #region Get mainAd ById
        TbMainAd IBusinessLayer<TbMainAd>.GetById(int id)
        {
            try
            {
                var ObjmainAd = mainAdRepository.FindBy(a => a.mainAdID == id && a.MainAdCurrentState == 1).FirstOrDefault();
                return ObjmainAd;
            }
            catch
            {
                return new TbMainAd();
            }
        }
        #endregion

        #region Save mainAd in DataBase
        bool IBusinessLayer<TbMainAd>.Save(TbMainAd table)
        {
            try
            {
                if (table.mainAdID == 0)
                {
                    table.MainAdCurrentState = 1;
                    mainAdRepository.Add(table);
                }
                else
                {
                    mainAdRepository.Edit(table);
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
