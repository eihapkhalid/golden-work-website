using Bl.Interfaces;
using Domains;
using GoldenWorkWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Controllers
{
    public class CustomerReviewController : Controller
    {
        #region Dependancy Injections
        private IBusinessLayer<TbAbout> oAboutService;
        private IBusinessLayer<TbService> oServiceService;
        private IBusinessLayer<TbCustomer> ocustomerService;
        private IBusinessLayer<TbTechnician> otechnicianService;
        private IBusinessLayer<TbCustomerReview> ocustomerReviewnService;
        private IBusinessLayer<TbMainAd> omainAdService;
        private IBusinessLayer<TbBooking> obookingService;

        private readonly IUnitOfWork unitOfWork;
        public CustomerReviewController(IBusinessLayer<TbAbout> _aboutService, IUnitOfWork _unitOfWork, IBusinessLayer<TbService> _oServiceService, IBusinessLayer<TbBooking> _obookingService, IBusinessLayer<TbCustomer> _ocustomerService, IBusinessLayer<TbTechnician> _otechnicianService, IBusinessLayer<TbCustomerReview> _ocustomerReviewnService, IBusinessLayer<TbMainAd> _omainAdService)
        {


            unitOfWork = _unitOfWork;
            oAboutService = _aboutService;
            oServiceService = _oServiceService;
            obookingService = _obookingService;
            ocustomerService = _ocustomerService;
            otechnicianService = _otechnicianService;
            ocustomerReviewnService = _ocustomerReviewnService;
            omainAdService = _omainAdService;
        }
        #endregion
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            viewModel.lstTbAbouts = oAboutService.GetAll();
            viewModel.lstTbServices = oServiceService.GetAll();
            viewModel.lstTbCustomer = ocustomerService.GetAll();
            viewModel.lstTbTechnician = otechnicianService.GetAll();
            viewModel.lstTbCustomerReviews = ocustomerReviewnService.GetAll();
            viewModel.lstTbMainAd = omainAdService.GetAll();
            viewModel.inputTbBookings = new TbBooking();
            return View(viewModel);
        }
    }
}
