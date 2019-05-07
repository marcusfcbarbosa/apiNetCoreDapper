using Microsoft.AspNetCore.Mvc;

namespace _1_Api.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public string Get(){

            return "Hello";
        }
        
    }
}