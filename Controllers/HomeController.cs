using ilanApp.Models;
using ilanApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ilanApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBContext _context;
        public HomeController(DBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string SearchString,string Category)
        {
            IQueryable<advertInfo> query = _context.AdvertInfs;
            if (!String.IsNullOrEmpty(SearchString))
            {
                ViewBag.SearchString = SearchString;
                SearchString = SearchString.ToLower();
                query = query.Where(a => a.title!.ToLower().Contains(SearchString));
            }
            if (!String.IsNullOrEmpty(Category) && Category != "0")
            {
               query = query.Where(a => a.CategoryId == int.Parse(Category));
            }
            List<advertInfo> advertData = query.ToList();

            var AdvertViewModel = new AdvertViewModel
            {
                AdvertsV = advertData,
                CategoriesV = await _context.categoriesInfs.ToListAsync(),
                SelectedCategory = Category
            };
            return View(AdvertViewModel);
        }
        public string List()
        {
            return "home/list";
        }
    }
}