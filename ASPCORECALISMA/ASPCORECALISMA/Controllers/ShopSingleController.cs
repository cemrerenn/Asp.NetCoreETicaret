using ASPCORECALISMA.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCORECALISMA.Controllers
{
    public class ShopSingleController : Controller
    {

        /*---- Ürün detay sayfası ----*/
        public IActionResult Index(int id)
        {

            Context c = new Context();
            var _urun = c.urunlers.Include(x=>x.Kategoriler).Include(x=>x.firmalar).FirstOrDefault(x=>x.UrunID==id);

            return View(_urun);
        }
    }
    }

