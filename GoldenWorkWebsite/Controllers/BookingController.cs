using Bl.Interfaces;
using Bl.Services;
using Domains;
using GoldenWorkWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Controllers
{
    public class BookingController : Controller
    {
        private IBusinessLayer<TbBooking> oBookingService;
        private IBusinessLayer<TbAbout> oAboutService;
        private IBusinessLayer<TbService> oServiceService;

        private readonly IUnitOfWork unitOfWork;
        public BookingController(IUnitOfWork _unitOfWork, IBusinessLayer<TbBooking> _oBookingService, IBusinessLayer<TbAbout> _oAboutService, IBusinessLayer<TbService> _oServiceService)
        {
            oBookingService = _oBookingService;
            oAboutService = _oAboutService;
            unitOfWork = _unitOfWork;
            oServiceService = _oServiceService;
        }

        public IActionResult Booking()
        {
            var viewModel = new IndexViewModel();
            viewModel.lstTbAbouts = oAboutService.GetAll();
            viewModel.lstTbServices = oServiceService.GetAll();
            return View(viewModel);
        }

        #region Save by bankAccount object
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Save")]
        public IActionResult Save(IndexViewModel viewModel)
        {
            /*
            if (!ModelState.IsValid)
            {

            }
            */
            oBookingService.Save(viewModel.inputTbBookings);
            unitOfWork.Dispose();
            return RedirectToAction("Booking");
        }

        #endregion
    }
}
