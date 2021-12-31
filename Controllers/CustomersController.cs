using Kunashko_lb3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kunashko_lb3.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Add(int id)
        {
            return View(Storage.Products.FirstOrDefault(product => product.Id == id));
        }
    }
}
