using Microsoft.AspNetCore.Mvc;

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

            return View();
        }
    }
}
