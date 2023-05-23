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

        List<TbUser> IBusinessLayer<TbUser>.GetAll()
        {
            throw new NotImplementedException();
        }

        TbUser IBusinessLayer<TbUser>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        bool IBusinessLayer<TbUser>.Save(TbUser table)
        {
            throw new NotImplementedException();
        }
    }
}
