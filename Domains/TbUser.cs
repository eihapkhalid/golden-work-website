using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserRole { get; set; }
        public int UserUpdate { get; set; }
        public int UserCreate { get; set; }
        public DateTime UserUpdateTime { get; set; }
        public DateTime UserCreateTime { get; set; }
        public int UserCurrentState { get; set; }
    }
}
