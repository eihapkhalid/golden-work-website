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
    public class NewsService : IBusinessLayer<TbNews>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<TbNews> newsRepository;

        public NewsService(IUnitOfWork _unitOfWork, IGenericRepository<TbNews> _newsRepository)
        {
            unitOfWork = _unitOfWork;
            newsRepository = _newsRepository;
        }
        #endregion

        #region Delete News
        bool IBusinessLayer<TbNews>.Delete(int id)
        {
            try
            {

                var news = ((IBusinessLayer<TbNews>)this).GetById(id);
                news.NewsCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All News
        List<TbNews> IBusinessLayer<TbNews>.GetAll()
        {
            try
            {
                return (List<TbNews>)newsRepository.Get_All();
            }
            catch
            {
                return new List<TbNews>();
            }
        }
        #endregion

        #region Get News ById
        TbNews IBusinessLayer<TbNews>.GetById(int id)
        {
            try
            {
                var ObjNews = newsRepository.FindBy(a => a.NewsID == id && a.NewsCurrentState == 1).FirstOrDefault();
                return ObjNews;
            }
            catch
            {
                return new TbNews();
            }
        }
        #endregion

        #region Save News in DataBase
        bool IBusinessLayer<TbNews>.Save(TbNews table)
        {
            try
            {
                if (table.NewsID == 0)
                {
                    table.NewsCurrentState = 1;
                    newsRepository.Add(table);
                }
                else
                {
                    newsRepository.Edit(table);
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
