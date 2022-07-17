using Microsoft.AspNetCore.Mvc;

namespace BookStoreAdmin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
