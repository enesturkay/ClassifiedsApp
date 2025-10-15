using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ilanApp.Models
{
    public class advertInfo
    {
        [BindNever]
        public int id { get; set; }
        [Required (ErrorMessage ="Lütfen Bir başlık belirleyin.")]
        public string? title { get; set; }
        [Required (ErrorMessage ="Lütfen Bir açıklama belirleyin.")]
        public string? desc { get; set; }
       

        public string? image { get; set; }
        
        [Required (ErrorMessage ="Lütfen Bir Kategori belirleyin.")]
        public int CategoryId { get; set; }
        [Required (ErrorMessage ="Lütfen bir fiyat belirleyin.")]
        [Range(0,100000000)]
        public int? price { get; set; }
    }
}