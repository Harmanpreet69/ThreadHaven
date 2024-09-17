using Microsoft.AspNetCore.Mvc;
using ThreadHaven.Models;

namespace ThreadHaven.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: shop/ByCategory/123
        public IActionResult ByCategory(int id)
        {
            switch(id)
            {
                case 1:
                    ViewData["Category"] = "Sweaters";
                    break;
                case 2:
                    ViewData["Category"] = "Hoodies";
                    break;
                case 3:
                    ViewData["Category"] = "Pants";
                    break;
                case 4:
                    ViewData["Category"] = "Jeans";
                    break;
                default:
                    return RedirectToAction("Index");
            }

            // Use Product Model to make an in-memory list of products
            var products = new List<Product>();

            for(int i = 0; i < 5; i++)
            {
                products.Add(new Product{ Id = i, Name="product " + i, Description = "product description " + i, Price = i });
            }

            return View(products);
        }
    }
}
