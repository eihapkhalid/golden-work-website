using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbCustomerReview
    {
        public int CustomerReviewID { get; set; }
        public string CustomerID { get; set;}
        public string CustomerReviewText { get; set;}
        public int CustomerReviewRating { get; set;}
        public string CustomerReviewLogo { get; set;}
        public DateTime UserUpdateTime { get; set; }
        public DateTime UserCreateTime { get; set; }
        public int CustomerReviewCurrentlyFeatured { get; set;}
        public int CustomerReviewCurrentState { get; set; }
    }
}
