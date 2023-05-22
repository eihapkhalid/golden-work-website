using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbService
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public decimal ServicePrice { get; set; }
        public string ServiceImage { get; set;}
        public DateTime UserUpdateTime { get; set; }
        public DateTime UserCreateTime { get; set; }
        public string ServiceCurrentlyFeatured { get; set;}
        public int ServiceCurrentState { get; set; }

    }
}
