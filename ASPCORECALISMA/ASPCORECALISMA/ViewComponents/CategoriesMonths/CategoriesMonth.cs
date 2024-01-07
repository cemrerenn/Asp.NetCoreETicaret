using ASPCORECALISMA.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORECALISMA.ViewComponents.CategoriesMonths
{
    public class CategoriesMonth:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var kategori = c.categoriesMonths.ToList();
            return View(kategori);
        }
    }
}
