using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbBooking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set;}
        public int ServiceID { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingEndDate { get; set;}
        public DateTime UserUpdateTime { get; set; }
        public DateTime UserCreateTime { get; set; }
        public int BookingCurrentState { get; set; }

        //TbBooking has only user (Update Or Create):
        public TbUser UpdatedByUser { get; set; }
        public TbUser CreatedByUser { get; set; }
    }
}
