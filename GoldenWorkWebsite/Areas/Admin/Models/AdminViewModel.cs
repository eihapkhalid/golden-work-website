using Domains;
namespace GoldenWorkWebsite.Areas.Admin.Models
{
    public class AdminViewModel
    {
        public List<TbUser> LesTbUsers { get;set; }
        public List<TbAbout> LesTbAbouts { get; set; }
        public List<TbCustomer> LesTbCustomers { get; set; }
        public List<TbService> LesTbServices { get; set; }
        public List<TbCustomerReview> LesTbCustomerReviews { get; set; }
        public List<TbBooking> LesTbBookings { get; set; }
        public List<TbMainAd> LesTbMainAds { get; set; }
        public List<TbTechnician> LesTechnicians { get; set; }

        public TbUser inpTbUser { get; set; }
        public TbAbout inpTbAbout { get; set; }
        public TbCustomer inpTbCustomer { get; set; }
        public TbService inpTbService { get; set; }
        public TbCustomerReview inpTbCustomerReview { get; set; }
        public TbBooking inpTbBooking { get; set; }
        public TbMainAd inpTbMainAd { get; set; }
        public TbTechnician inpTbTechnician { get; set; }

    }
}
