using ASPCORECALISMA.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ASPCORECALISMA.Controllers
{
    public class ShopController : Controller
    {
        [Authorize(Roles = "Admin,Satici,Musteri")]

        public IActionResult Index(int id)
        {
         
            Context c = new Context();

            if (id == 0)
            {
                var urun = c.urunlers.Include(x => x.Kategoriler).ToList();
                return View(urun);
            }
            else
            {
                var _urun = c.urunlers.Include(x => x.Kategoriler).Where(x => x.UrunKategoriID == id).ToList();

                return View(_urun);
            }

           
        }
    }
}
