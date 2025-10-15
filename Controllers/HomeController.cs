using ilanApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ilanApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string SearchString,string Category)
        {
            List<advertInfo> advertData = Repository.AdvertInfo;
            if (!String.IsNullOrEmpty(SearchString))
            {
                ViewBag.SearchString = SearchString;
                advertData = advertData.Where(a => a.title!.ToLower().Contains(SearchString)).ToList();
            }
            if (!String.IsNullOrEmpty(Category) && Category != "0")
            {
                advertData = advertData.Where(a => a.CategoryId == int.Parse(Category)).ToList();
            }
        
            var AdvertViewModel = new AdvertViewModel
            {
                AdvertsV = advertData,
                CategoriesV = Repository.categories,
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