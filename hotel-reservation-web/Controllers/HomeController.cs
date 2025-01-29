using Microsoft.AspNetCore.Mvc;

namespace hotel_reservation_web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Home()
        {
            return View();
        }
       
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
