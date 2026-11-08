using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Ноутбук Lenovo IdeaPad", Price = 285000, Category = "Электроника", IsAvailable = true },
            new Product { Id = 2, Name = "Смартфон Samsung Galaxy", Price = 195000, Category = "Электроника", IsAvailable = true },
            new Product { Id = 3, Name = "Құлаққап Sony WH-1000", Price = 98000, Category = "Аксессуар", IsAvailable = false },
            new Product { Id = 4, Name = "Тінтуір Logitech MX", Price = 32000, Category = "Аксессуар", IsAvailable = true },
            new Product { Id = 5, Name = "C# бағдарламалау кітабы", Price = 8500, Category = "Кітаптар", IsAvailable = true },
            new Product { Id = 6, Name = "Монитор Dell 24\"", Price = 87000, Category = "Электроника", IsAvailable = false }
        };

        public IActionResult Index()
        {
            ViewBag.Title = "Тауарлар тізімі";
            ViewBag.TotalCount = _products.Count;
            ViewBag.AvailableCount = _products.Count(p => p.IsAvailable);
            return View(_products); // Strongly typed: IEnumerable<Product>
        }

        public IActionResult Details(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
