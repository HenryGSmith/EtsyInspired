using EtsyInspired.Models;
using EtsyInspired.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EtsyInspired.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> products { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger, 
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService= productService;
        }

        public void OnGet()
        {
            products = ProductService.GetProducts();
        }
    }
}