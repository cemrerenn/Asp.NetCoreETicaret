using ASPCORECALISMA.Concrete;
using ASPCORECALISMA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCORECALISMA.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        protected readonly UserManager<Kullanicilar> _usermanager;
        protected readonly RoleManager<KullaniciRol> _rolmanager;

        public AdminController(UserManager<Kullanicilar> usermanager,RoleManager<KullaniciRol> rolmanager)
        {
            _usermanager = usermanager;
            _rolmanager = rolmanager;
        }

        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AdminCarousel() 
        {
            var carousel = c.carousels.ToList();

            return View(carousel);
        }

        [HttpPost]
        public IActionResult AdminCarousel(int id,string baslik,string altbaslik,string aciklama, string foto)
        {
            var carousel = c.carousels.FirstOrDefault(x => x.CaroueselID == id);
                if(carousel!=null)
                {
                    carousel.CarouselFotoUrl = foto;
                    carousel.CarouselBaslik = baslik;
                    carousel.CarouselAltBaslik = altbaslik;
                    carousel.CarouselAciklama = aciklama;
                    c.SaveChanges();    
                    return RedirectToAction("AdminCarousel");
                    
                }

            return View();
        }

        [HttpGet]
        public IActionResult CategoriesMonth()
        {
            var kategori = c.categoriesMonths.ToList(); 
            return View(kategori);

        }
        [HttpPost]
        public IActionResult CategoriesMonth(int id, string baslik, string foto)
        {
            var kat = c.categoriesMonths.FirstOrDefault(x => x.UrunID == id);
            if (kat != null)
            {
                kat.UrunFoto = foto;
                kat.UrunBaslik = baslik;
                c.SaveChanges();
                return RedirectToAction("CategoriesMonth");


            }

            return View();

        }
        [HttpGet]
        public IActionResult Urunler(int id) 
        {
            var urun = c.urunlers.FirstOrDefault(x=>x.UrunID==id);
            if (urun != null)
            {
                c.urunlers.Remove(urun);
                c.SaveChanges();
                return RedirectToAction("urunler");
            }

            var urunlist = c.urunlers.Include(x=>x.Kategoriler).Include(x=>x.firmalar).ToList();
            return View(urunlist);
        }

        [HttpGet]
        public IActionResult UrunGuncelle(int id)
        {
            var urunlist = c.urunlers.Include(x => x.Kategoriler).Include(x => x.firmalar).FirstOrDefault(x=>x.UrunID==id);
            return View(urunlist);
            
        }

        [HttpPost]
        public IActionResult UrunGuncelle(int id,string urunad,int fiyat,string aciklama)
        {
            var guncelle = c.urunlers.FirstOrDefault(x=>x.UrunID == id);
            if (guncelle != null)
            {
                guncelle.UrunAdi = urunad;
                guncelle.UrunAciklama = aciklama;
                guncelle.UrunFiyat = fiyat;

                c.SaveChanges();
                return RedirectToAction("Urunler");
            }
            return View();
        }
        [HttpGet]
        public IActionResult FirmalarList(int id)
        {
            var firmasil = c.firmalars.Include(x=>x.iller).FirstOrDefault(x => x.FirmaID == id);
            if (firmasil != null)
            {
                c.firmalars.Remove(firmasil);
                c.SaveChanges();
                return RedirectToAction("FirmalarList");
            }
            var firmalist1 = c.firmalars.Include(x => x.iller).ToList();
            return View(firmalist1);

        }

        [HttpGet]
        public IActionResult FirmalarDetay(int id)
        {
            var firmadetay =c.firmalars.Include(x=>x.iller).FirstOrDefault(c => c.FirmaID == id); 
            return View(firmadetay);
        }
       
        public IActionResult MusterilerList()
        {
           var mus = c.kullanicilars.ToList();
           return View(mus);

           

          
        }

        [HttpGet]
        public IActionResult Contact(int id)
        {
            var sil = c.contacts.FirstOrDefault(x=>x.BildirimID==id);
            if (sil != null) 
            {
                c.contacts.Remove(sil);
                c.SaveChanges(); 
                return RedirectToAction("Contact");
            }
            

            var bil = c.contacts.ToList();
            return View(bil); 
        }

        public IActionResult GetRol()
        {
            var roller =_rolmanager.Roles.ToList();

            return View(roller);
        }
      

    }
}
