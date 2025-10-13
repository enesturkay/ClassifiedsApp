using ilanApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ilanApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AdvertInfo);
        }
        public string List()
        {
            return "home/list";
        }
    }
}