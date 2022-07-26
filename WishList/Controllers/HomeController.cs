using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToPage("/Home/Index");
        }

        public IActionResult Error() 
        {
            return RedirectToPage("/Shared/Index");
        }
    }
}
