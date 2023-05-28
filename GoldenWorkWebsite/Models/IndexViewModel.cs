using Domains;
namespace GoldenWorkWebsite.Models
{
    public class IndexViewModel
    {
        public List<TbAbout> lstTbAbouts { get; set; }
        public List<TbCustomer> lstTbCustomer { get; set; }
        public List<TbCustomerReview> lstTbCustomerReviews { get; set; }
        public List<TbService> lstTbServices { get; set; }
        public List <TbTechnician> lstTbTechnician { get; set; }
        public List<TbMainAd> lstTbMainAd { get; set; }
        public TbBooking inputTbBookings { get; set; }
        public TbContact inputTbContacts { get; set; }


    }
}
