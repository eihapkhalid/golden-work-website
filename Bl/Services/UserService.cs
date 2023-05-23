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
        bool IBusinessLayer<TbUser>.Delete(int id)
        {
            throw new NotImplementedException();
        }

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
