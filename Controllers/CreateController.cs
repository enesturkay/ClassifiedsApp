using ilanApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ilanApp.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult Advert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Advert(advertInfo model)
        {
            if (ModelState.IsValid)
            {
                model.id = Repository.AdvertInfo.Count();
                Repository.CreateAdvert(model);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult AdvertDetails(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}