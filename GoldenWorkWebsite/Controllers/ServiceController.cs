using Bl.Interfaces;
using Domains;
using GoldenWorkWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Controllers
{
    public class ServiceController : Controller
    {
        #region Dependancy Injections
        private IBusinessLayer<TbService> oServiceService;
        private IBusinessLayer<TbAbout> oAboutService;
        public ServiceController(IBusinessLayer<TbAbout> _oAboutService, IBusinessLayer<TbService> _oServiceService)
        {
            oServiceService = _oServiceService;
            oAboutService = _oAboutService;
        }
        #endregion
        public IActionResult Service()
        {
            var viewModel = new IndexViewModel();
            viewModel.lstTbAbouts = oAboutService.GetAll();
            viewModel.lstTbServices = oServiceService.GetAll();
            return View(viewModel);
        }
    }
}
