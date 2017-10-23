namespace InkyTagHelpers.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Order")]
        public IActionResult Order()
        {
            return View();
        }

        [Route("Password")]
        public IActionResult Password()
        {
            return View();
        }

        [Route("Welcome")]
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
