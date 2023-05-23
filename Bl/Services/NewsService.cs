using Bl.Interfaces;
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
        #region define DbContext
        private GoldenWorkDbContext context;
        private readonly IUnitOfWork unitOfWork;
        public TechnicianService(GoldenWorkDbContext ctx, IUnitOfWork _unitOfWork)
        {
            context = ctx;
            unitOfWork = _unitOfWork;
        }
        #endregion

        #region Delete News
        bool IBusinessLayer<TbNews>.Delete(int id)
        {
            try
            {

                var news = GetById(id);
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
                var lstNews = context.TbNews.Where(a => a.NewsCurrentState == 1).ToList();
                return lstNews;
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
                var ObjNews = context.TbNews.Where(a => a.NewsID == id && a.NewsCurrentState == 1).FirstOrDefault();
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
                    context.TbNews.Add(table);
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
