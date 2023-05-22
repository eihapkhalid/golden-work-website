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

        //many of users have many proccecs for (Updating Or Creating):
        public ICollection<TbAbout> AboutUpdatedByUser { get; set; }
        public ICollection<TbAbout> AboutCreatedByUser { get; set; }

        public ICollection<TbBooking> BookingUpdatedByUser { get; set; }
        public ICollection<TbBooking> BookingCreatedByUser { get; set; }

        public ICollection<TbContact> ContactUpdatedByUser { get; set; }
        public ICollection<TbContact> ContactCreatedByUser { get; set; }

        public ICollection<TbCustomer> CustomerUpdatedByUser { get; set; }
        public ICollection<TbCustomer> CustomerCreatedByUser { get; set; }

        public ICollection<TbCustomerReview> CustomerReviewUpdatedByUser { get; set; }
        public ICollection<TbCustomerReview> CustomerReviewCreatedByUser { get; set; }

        public ICollection<TbNews> NewsUpdatedByUser { get; set; }
        public ICollection<TbNews> NewsCreatedByUser { get; set; }

        public ICollection<TbService> ServiceUpdatedByUser { get; set; }
        public ICollection<TbService> ServiceCreatedByUser { get; set; }

        public ICollection<TbTechnician> TechnicianUpdatedByUser { get; set; }
        public ICollection<TbTechnician> TechnicianCreatedByUser { get; set; }
    }
}
