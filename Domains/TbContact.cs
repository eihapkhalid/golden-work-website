using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbContact
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public int ContactPhone { get; set; }
        public string ContactMessage { get; set; }
        public DateTime UserUpdateTime { get; set; }
        public DateTime UserCreateTime { get; set; }
        public int ContactCurrentState { get; set; }
    }
}
