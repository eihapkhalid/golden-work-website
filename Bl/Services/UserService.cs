using Bl.Interfaces;
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
        #region define DbContext
        private GoldenWorkDbContext context;
        private readonly IUnitOfWork unitOfWork;
        public UserService(GoldenWorkDbContext ctx, IUnitOfWork _unitOfWork)
        {
            context = ctx;
            unitOfWork = _unitOfWork;
        }
        #endregion

        #region Delete User
        bool IBusinessLayer<TbUser>.Delete(int id)
        {
            try
            {

                var user = GetById(id);
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
                var lstUsers = context.TbUser.Where(a => a.UserCurrentState == 1).ToList();
                return lstUsers;
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
                var ObjUser = context.TbUser.Where(a => a.UserID == id && a.UserCurrentState == 1).FirstOrDefault();
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
                    context.TbUser.Add(table);
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
            #endregion

        }
    }
}
