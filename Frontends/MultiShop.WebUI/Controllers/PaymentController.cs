using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            @ViewBag.directory1 = "MultiShop";
            @ViewBag.directory2 = "Payment Screen";
            @ViewBag.directory3 = "Payment by Card";
            return View();
        }
    }
}
