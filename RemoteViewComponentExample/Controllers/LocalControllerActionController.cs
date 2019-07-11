using Microsoft.AspNetCore.Mvc;

namespace RemoteViewComponentExample.Controllers
{
    public class LocalControllerActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}