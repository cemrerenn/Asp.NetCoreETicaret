using ASPCORECALISMA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASPCORECALISMA.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<Kullanicilar> _userManager;

        public RegisterUserController(UserManager<Kullanicilar> userManager)
        {
            _userManager = userManager;
        }





        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignupModel s)
        {

            Kullanicilar kullanicilar = new Kullanicilar()
            {
                Email = s.Mail,
                UserName = s.UserName,
                KullaniciAD=s.Name,
                KullaniciSoyad=s.Surname,
                


            };
            var kayit =await _userManager.CreateAsync(kullanicilar,s.Password);

            if(kayit.Succeeded) 
            {
                var rolekle = await _userManager.AddToRoleAsync(kullanicilar,"Musteri");
                if(rolekle.Succeeded) 
                {
                    return RedirectToAction("index","Home");
                }
                else
                {
                    foreach (var item in kayit.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
              
            }
            else
            {
                foreach (var item in kayit.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }

            }


            return View();
        }



    }
}
