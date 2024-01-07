using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORECALISMA.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
