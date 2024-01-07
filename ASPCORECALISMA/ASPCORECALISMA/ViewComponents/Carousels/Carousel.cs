using ASPCORECALISMA.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORECALISMA.ViewComponents.Carousels
{
    public class Carousel:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();

            var carousels = c.carousels.ToList();
            return View(carousels);
        }
    }
}
