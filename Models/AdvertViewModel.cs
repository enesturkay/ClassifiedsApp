using System.Net.Http.Headers;

namespace ilanApp.Models
{
    public class AdvertViewModel
    {
        public List<advertInfo> AdvertsV { get; set; } = null!;
        public List<Category> CategoriesV { get; set; } = null!;
        public string? SelectedCategory { get; set; }
    }
}