using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View("/Home/Index");
        }

        public IActionResult Error() 
        {
            return View("/Shared/Index");
        }
    }
}
