using ASPCORECALISMA.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCORECALISMA.ViewComponents.ShopCard
{
    public class shopcards:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
           

            return View();
        }
    }
}
