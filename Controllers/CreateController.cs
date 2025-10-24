using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using ilanApp.Models;
using ilanApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ilanApp.Controllers
{
    public class CreateController : Controller
    {

        private readonly DBContext _context;
        public CreateController(DBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Removes(int? id)
        {
             if (id == null) return NotFound();
            var forRemove = await _context.AdvertInfs.FindAsync(id);
            if (forRemove == null) return NotFound();
           
            return View(forRemove);
        }
        [HttpPost] 
        public async Task<IActionResult> Removes(advertInfo Advert )
        {
                try
                {
                     _context.AdvertInfs.Remove(Advert);
                     await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Home");

                }
                catch (Exception)
                {
                    return NotFound();
                }
           
        }
        public async Task<IActionResult> Advert()
        {
            var categoriesList = await _context.categoriesInfs.ToListAsync();
            ViewBag.categories = new SelectList(categoriesList, "CategoryId", "Name");
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
                if (!allowedExtensions.Contains(extension.ToLower()))
                {
                    return BadRequest("Yanlış Dosya uzantısı girildi.");
                }
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                model.image = "/image/" + randomFileName;
                _context.AdvertInfs.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }
        public async Task<IActionResult> AdvertDetails(int? id)
        {
            if (id == null) return NotFound();
            var advert = await _context.AdvertInfs.FindAsync(id);
            if (advert == null) return NotFound();
            var viewModel = new AdvertViewModel
            {
                AdvertsV = new List<advertInfo> { advert! },
                CategoriesV =await _context.categoriesInfs.ToListAsync(),
                SelectedCategory = advert!.CategoryId.ToString()
            };
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var advert = await _context.AdvertInfs.FindAsync(id);
            if (advert == null) return NotFound();
            ViewBag.Categories = new SelectList(_context.categoriesInfs, "CategoryId", "Name");
            return View(advert);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(advertInfo Advert, IFormFile? formFile)
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
                    Advert.image = "/image/" + randomFileName;
                }
                try
                {
                    _context.Update(Advert);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Home");

                }
                catch (Exception)
                {
                    return NotFound();
                }
            }
            return View(Advert);
        }


    }
}