using Microsoft.AspNetCore.Mvc;

namespace ProductCatalogAPI.Controllers
{
    [ApiController]

    public class HelloWorldController : Controller
    {
        [HttpGet("/hello-world")]
        public string hello()
        {
            return "Hello World";
        }
    }
}
