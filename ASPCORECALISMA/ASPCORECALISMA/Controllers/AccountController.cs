using ASPCORECALISMA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORECALISMA.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
    
        private readonly UserManager<Kullanicilar> _usermanager;
        private readonly SignInManager<Kullanicilar> _SignInManager;
       
        public AccountController(SignInManager<Kullanicilar> signInManager,UserManager<Kullanicilar> usermanager)
        {
            _usermanager = usermanager;
            _SignInManager = signInManager;
        }
      
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
      
        [HttpPost]
        public async Task< IActionResult> Login(UserSignInModel u)
        {
            if(ModelState.IsValid) 
            {
                var user = await _usermanager.FindByNameAsync(u.username);

                var sonuc = await _SignInManager.PasswordSignInAsync(user, u.password,false,false) ;

                if (sonuc.Succeeded)
                {
                    return RedirectToAction("Index", "shop");
                }
                else
                {
                    return RedirectToAction("Login","Account");
                }
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _SignInManager.SignOutAsync();
            return RedirectToAction("index","Home");
        }


      
    }
}
