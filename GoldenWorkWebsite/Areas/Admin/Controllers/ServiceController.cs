using Bl.Interfaces;
using Domains;
using GoldenWorkWebsite.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ServiceController : Controller
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
        public ServiceController(IBusinessLayer<TbAbout> _aboutService, IUnitOfWork _unitOfWork, IBusinessLayer<TbService> _oServiceService, IBusinessLayer<TbTechnician> _otechnicianService, IBusinessLayer<TbCustomer> _ocustomerService, IBusinessLayer<TbCustomerReview> _ocustomerReviewnService, IBusinessLayer<TbUser> _oUseService)
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
        public IActionResult ServiceList()
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
        public IActionResult ServiceEdit(int? serviceid)
        {
            viewModel.LesTbAbouts = oAboutService.GetAll();
            if (serviceid != null)
            {
                viewModel.inpTbService = oServiceService.GetById(Convert.ToInt32(serviceid));
            }
            ViewData.Model = viewModel;
            unitOfWork.Dispose();
            return View();
        }
        #endregion

        #region Save by user object
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("ServiceSave")]
        public IActionResult ServiceSave(AdminViewModel viewModel)
        {
            /*
            if (!ModelState.IsValid)
            {

            }
            */
            oServiceService.Save(viewModel.inpTbService);
            unitOfWork.Dispose();
            return RedirectToAction("ServiceList");
        }

        #endregion

        #region Delete By bankAccount Id
        public IActionResult ServiceDelete(int userID)
        {
            oServiceService.Delete(userID);
            unitOfWork.Dispose();
            return RedirectToAction("ServiceList");
        }
        #endregion
    }
}
