using System.ComponentModel.Design;
using ilanApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ilanApp.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult Advert()
        {
            ViewBag.Categories = new SelectList(Repository.categories, "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Advert(advertInfo model, IFormFile formFile)
        {
            string[] allowedExtensions = new[] { "jpg", "png", "jpeg" };
            var extension = Path.GetExtension(formFile.FileName);
            var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image", randomFileName);
  
            if (ModelState.IsValid)
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                model.image = "/image/"+randomFileName;
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
            var advert = Repository.GetById(id);
            var viewModel = new AdvertViewModel
            {
                AdvertsV = new List<advertInfo> { advert },
                CategoriesV = Repository.categories,
                SelectedCategory = advert.CategoryId.ToString()
            };
            return View(viewModel);
        }
    }
}