using Microsoft.AspNetCore.Mvc;

namespace GoldenWorkWebsite.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
