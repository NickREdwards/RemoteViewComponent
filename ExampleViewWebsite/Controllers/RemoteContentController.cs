using Microsoft.AspNetCore.Mvc;

namespace ExampleViewWebsite.Controllers
{
    [Route("remotecontentfromwebsite")]
    public class RemoteContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}