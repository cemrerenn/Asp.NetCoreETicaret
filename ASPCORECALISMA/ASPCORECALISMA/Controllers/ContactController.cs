using ASPCORECALISMA.Concrete;
using ASPCORECALISMA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORECALISMA.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int id,string ad,string email,string baslik,string mesaj)
        {
            Context c = new Context();
         
          

           Contact _con = new Contact();
            {
               _con.BildirimAd = ad;
                _con.BildirimEposta = email;
                _con.BildirimKonu = baslik;
                _con.BildirimAciklama = mesaj;
            }

            c.contacts.Add(_con);
            c.SaveChanges();
            return RedirectToAction("Index");

           
        }
    }
}
