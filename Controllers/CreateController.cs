using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using ilanApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ilanApp.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult Advert()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Advert(advertInfo model, IFormFile formFile)
        {
            string[] allowedExtensions = new[] { ".jpg", ".png", ".jpeg" }; 



            if (ModelState.IsValid)
            {

                var extension = Path.GetExtension(formFile.FileName);
                var randomFileName = string.Format($"{Guid.NewGuid()}{extension}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image", randomFileName);
                if(!allowedExtensions.Contains(extension.ToLower()))
                {
                    return BadRequest("Yanlış Dosya uzantısı girildi.");
                }
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                model.image = "/image/" + randomFileName;
                model.id = Repository.AdvertInfo.Count() + 1;
                Repository.CreateAdvert(model);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult AdvertDetails(int? id)
        {
            if (id == null) return NotFound();
            var advert = Repository.GetById(id);
            if (advert == null) return NotFound();
            var viewModel = new AdvertViewModel
            {
                AdvertsV = new List<advertInfo> { advert! },
                CategoriesV = Repository.categories,
                SelectedCategory = advert!.CategoryId.ToString()
            };
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var advert = Repository.GetById(id);
            if (id == null) return NotFound();
            ViewBag.Categories = new SelectList(Repository.categories, "CategoryId", "Name");
            return View(advert);
        }
        [HttpPost]
        public async Task<IActionResult> Edit( advertInfo Advert, IFormFile? formFile)
        {
            Console.WriteLine($"Edit çağrıldı, id = {Advert.id}");

            if (ModelState.IsValid)
            {
                if (formFile != null)
                {
                    var extension = Path.GetExtension(formFile.FileName);
                    var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image", randomFileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                    Advert.image ="/image/"+ randomFileName;
                }
               
                Repository.EditbyId(Advert);
                return RedirectToAction("Index", "Home");
            }
            return View(Advert);
        }


    }
}