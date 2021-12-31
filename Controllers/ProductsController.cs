using Kunashko_lb3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kunashko_lb3.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult List()
        {
            return View(Storage.Products);
        }
        public IActionResult Details(int id)
        {
            return View(Storage.Products.FirstOrDefault(product => product.Id == id));
        }
    }
}
