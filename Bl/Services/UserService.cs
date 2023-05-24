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
    public class UserService : IBusinessLayer<TbUser>
    {
        #region define unitOfWork
        private readonly IUnitOfWork unitOfWork;
        private readonly IGenericRepository<TbUser> userRepository;

        public UserService(IUnitOfWork _unitOfWork, IGenericRepository<TbUser> _userRepository)
        {
            unitOfWork = _unitOfWork;
            userRepository = _userRepository;
        }
        #endregion

        #region Delete User
        bool IBusinessLayer<TbUser>.Delete(int id)
        {
            try
            {

                var user = ((IBusinessLayer<TbUser>)this).GetById(id);
                user.UserCurrentState = 0;
                unitOfWork.Commit(); //context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Get All Users
        List<TbUser> IBusinessLayer<TbUser>.GetAll()
        {
            try
            {
                return (List<TbUser>)userRepository.Get_All();
            }
            catch
            {
                return new List<TbUser>();
            }
        }
        #endregion

        #region Get User ById
        TbUser IBusinessLayer<TbUser>.GetById(int id)
        {
            try
            {
                var ObjUser = userRepository.FindBy(a => a.UserID == id && a.UserCurrentState == 1).FirstOrDefault();
                return ObjUser;
            }
            catch
            {
                return new TbUser();
            }
        }
        #endregion

        #region Save User in DataBase
        bool IBusinessLayer<TbUser>.Save(TbUser table)
        {
            try
            {
                if (table.UserID == 0)
                {
                    table.UserCurrentState = 1;
                    userRepository.Add(table);
                }
                else
                {
                    userRepository.Edit(table);
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
