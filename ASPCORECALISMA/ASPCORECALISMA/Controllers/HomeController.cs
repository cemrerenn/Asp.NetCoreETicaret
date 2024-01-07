using ASPCORECALISMA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPCORECALISMA.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

      
        public IActionResult Index()
        {
            return View();
        }

      
       
    }
}