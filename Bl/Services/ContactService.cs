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
    public class ContactService:IBusinessLayer<TbContact>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly ContactRepository contactRepository;

        public ContactService(IUnitOfWork _unitOfWork, ContactRepository _contactRepository)
        {
            unitOfWork = _unitOfWork;
            contactRepository = _contactRepository;
        }
        #endregion

        #region Delete contact
        bool IBusinessLayer<TbContact>.Delete(int id)
        {
            try
            {

                var contact = ((IBusinessLayer<TbContact>)this).GetById(id);
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
                return (List<TbContact>)contactRepository.Get_All();
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
                var Objcontact = contactRepository.FindBy(a => a.ContactID == id && a.ContactCurrentState == 1).FirstOrDefault();
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
                    contactRepository.Add(table);
                }
                else
                {
                    contactRepository.Edit(table);
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
