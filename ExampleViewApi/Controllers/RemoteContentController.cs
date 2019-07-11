using Microsoft.AspNetCore.Mvc;

namespace ExampleViewApi.Controllers
{
    [Route("api/remotecontentfromapi")]
    [ApiController]
    public class RemoteContentController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Content("Content coming from the remote view API!");
        }
    }
}
