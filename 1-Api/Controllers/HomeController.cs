using Microsoft.AspNetCore.Mvc;

namespace _1_Api.Controllers
{
    [Route("api/v1/Home")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public string Get(){

            return "Hello";
        }
   }
}