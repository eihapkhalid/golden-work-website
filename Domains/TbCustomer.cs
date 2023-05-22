using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbCustomer
    {
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set;}
        public int CustomerPhone { get; set;}
        public string CustomerAddress { get; set;}
        public string CustomerSatisfied { get; set;}
        public DateTime UserUpdateTime { get;set;}
        public DateTime UserCreateTime { get; set;}
        public int CustomerCurrentState { get; set;}
    }
}
