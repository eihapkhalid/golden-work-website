using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class ContactService:IBusinessLayer<TbContact>
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

        #region Delete contact
        bool IBusinessLayer<TbContact>.Delete(int id)
        {
            try
            {

                var contact = GetById(id);
                contact.ContactCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All contactS
        List<TbContact> IBusinessLayer<TbContact>.GetAll()
        {
            try
            {
                var lstcontact = context.TbContact.Where(a => a.ContactCurrentState == 1).ToList();
                return lstcontact;
            }
            catch
            {
                return new List<TbContact>();
            }
        }
        #endregion

        #region Get contact ById
        TbContact IBusinessLayer<TbContact>.GetById(int id)
        {
            try
            {
                var Objcontact = context.TbContact.Where(a => a.ContactID == id && a.ContactCurrentState == 1).FirstOrDefault();
                return Objcontact;
            }
            catch
            {
                return new TbContact();
            }
        }
        #endregion

        #region Save contact in DataBase
        bool IBusinessLayer<TbContact>.Save(TbContact table)
        {
            try
            {
                if (table.ContactID == 0)
                {
                    table.ContactCurrentState = 1;
                    context.TbContact.Add(table);
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
