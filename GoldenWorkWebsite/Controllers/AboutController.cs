using Bl.Interfaces;
using Bl.Services;
using Domains;
using GoldenWorkWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Controllers
{
    public class AboutController : Controller
    {
        #region Dependancy Injections
        private IBusinessLayer<TbAbout> oAboutService;
        private IBusinessLayer<TbService> oServiceService;
        private IBusinessLayer<TbTechnician> otechnicianService;
        private IBusinessLayer<TbCustomer> ocustomerService;
        private IBusinessLayer<TbCustomerReview> ocustomerReviewnService;
        private readonly IUnitOfWork unitOfWork;
        public AboutController(IBusinessLayer<TbAbout> _aboutService, IUnitOfWork _unitOfWork, IBusinessLayer<TbService> _oServiceService, IBusinessLayer<TbTechnician> _otechnicianService, IBusinessLayer<TbCustomer> _ocustomerService, IBusinessLayer<TbCustomerReview> _ocustomerReviewnService)
        {
            unitOfWork = _unitOfWork;
            oAboutService = _aboutService;
            oServiceService = _oServiceService;
            otechnicianService = _otechnicianService;
            ocustomerService = _ocustomerService;
            ocustomerReviewnService = _ocustomerReviewnService;
        }
        #endregion
        public IActionResult About()
        {
            var viewModel = new IndexViewModel();
            viewModel.lstTbAbouts = oAboutService.GetAll();
            viewModel.lstTbServices = oServiceService.GetAll();
            viewModel.lstTbTechnician = otechnicianService.GetAll();
            viewModel.lstTbCustomer = ocustomerService.GetAll();
            viewModel.lstTbCustomerReviews = ocustomerReviewnService.GetAll();
            return View(viewModel);
        }
    }
}
