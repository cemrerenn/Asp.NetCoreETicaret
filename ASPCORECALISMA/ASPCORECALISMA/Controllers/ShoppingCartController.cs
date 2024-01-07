using Microsoft.AspNetCore.Mvc;

namespace ASPCORECALISMA.Controllers
{
    public class ShoppingCartController : Controller
    {
        /*---- Sepetim sayfası ----*/
        public IActionResult Index()
        {
            return View();
        }
    }
}
