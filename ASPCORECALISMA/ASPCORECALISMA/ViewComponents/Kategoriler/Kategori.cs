using ASPCORECALISMA.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORECALISMA.ViewComponents.Kategoriler
{
    public class Kategori : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var kategori = c.kategorilers.ToList();


            return View(kategori);
        }
    }
}
