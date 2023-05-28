using Bl.Interfaces;
using Bl.Repositories;
using Bl.Services;
using Domains;
using GoldenWorkWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Controllers
{
    public class ContactController : Controller
    {
        private IBusinessLayer<TbContact> oContactService;
        private IBusinessLayer<TbAbout> oAboutService;

        private readonly IUnitOfWork unitOfWork;
        public ContactController(IUnitOfWork _unitOfWork, IBusinessLayer<TbContact> _oContactService, IBusinessLayer<TbAbout> _oAboutService)
        {
            oContactService = _oContactService;
            oAboutService = _oAboutService;
            unitOfWork = _unitOfWork;
        }

        public IActionResult Contact()
        {
            var viewModel = new IndexViewModel();
            viewModel.lstTbAbouts = oAboutService.GetAll();
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
            oContactService.Save(viewModel.inputTbContacts);
            unitOfWork.Dispose();
            return RedirectToAction("Contact");
        }

        #endregion
    }
}
