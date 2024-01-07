using Microsoft.AspNetCore.Mvc;

namespace ASPCORECALISMA.ViewComponents.ComingSoons
{
    public class ComingSoon:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
