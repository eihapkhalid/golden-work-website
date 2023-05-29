using Bl.Interfaces;
using Bl.Services;
using Domains;
using GoldenWorkWebsite.Areas.Admin.Models;
using GoldenWorkWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        #region Dependancy Injections oUseService
        private IBusinessLayer<TbUser> oUseService;
        private IBusinessLayer<TbAbout> oAboutService;
        private IBusinessLayer<TbService> oServiceService;
        private IBusinessLayer<TbTechnician> otechnicianService;
        private IBusinessLayer<TbCustomer> ocustomerService;
        private IBusinessLayer<TbCustomerReview> ocustomerReviewnService;
        private AdminViewModel viewModel = new AdminViewModel();
        private readonly IUnitOfWork unitOfWork;
        public UserController(IBusinessLayer<TbAbout> _aboutService, IUnitOfWork _unitOfWork, IBusinessLayer<TbService> _oServiceService, IBusinessLayer<TbTechnician> _otechnicianService, IBusinessLayer<TbCustomer> _ocustomerService, IBusinessLayer<TbCustomerReview> _ocustomerReviewnService, IBusinessLayer<TbUser> _oUseService)
        {
            unitOfWork = _unitOfWork;
            oAboutService = _aboutService;
            oServiceService = _oServiceService;
            otechnicianService = _otechnicianService;
            ocustomerService = _ocustomerService;
            ocustomerReviewnService = _ocustomerReviewnService;
            oUseService = _oUseService;
        }
        #endregion
        public IActionResult UserList()
        {
            viewModel.LesTbUsers = oUseService.GetAll();
            viewModel.LesTbAbouts = oAboutService.GetAll();
            viewModel.LesTbServices = oServiceService.GetAll();
            viewModel.LesTechnicians = otechnicianService.GetAll();
            viewModel.LesTbCustomers = ocustomerService.GetAll();
            viewModel.LesTbCustomerReviews = ocustomerReviewnService.GetAll();
            return View(viewModel);
        }

        #region Edit by user id
        public IActionResult Edit(int? userID)
        {            
            if (userID != null)
            {
                oUseService = oUseService.GetById(userID);
            }
            unitOfWork.Dispose();
            return View(viewModel.inpTbUser);
        }
        #endregion

        #region Save by user object
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Save")]
        public IActionResult Save(AdminViewModel viewModel)
        {
            /*
            if (!ModelState.IsValid)
            {

            }
            */
            oUseService.Save(viewModel.inpTbUser);
            unitOfWork.Dispose();
            return RedirectToAction("UserList");
        }

        #endregion
    }
}
