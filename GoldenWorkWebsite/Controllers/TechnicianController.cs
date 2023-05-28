using Bl.Interfaces;
using Bl.Services;
using Domains;
using GoldenWorkWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Controllers
{
    public class TechnicianController : Controller
    {
        #region Dependancy Injections
        private IBusinessLayer<TbTechnician> otechnicianService;
        private IBusinessLayer<TbAbout> oAboutService;
        public TechnicianController(IBusinessLayer<TbTechnician> _otechnicianService, IBusinessLayer<TbAbout> _aboutService)
        {
            otechnicianService = _otechnicianService;
            oAboutService = _aboutService;
        }
        #endregion
        public IActionResult Technician()
        {
            var viewModel = new IndexViewModel();
            viewModel.lstTbAbouts = oAboutService.GetAll();
            viewModel.lstTbTechnician = otechnicianService.GetAll();
            return View(viewModel);
        }
    }
}
