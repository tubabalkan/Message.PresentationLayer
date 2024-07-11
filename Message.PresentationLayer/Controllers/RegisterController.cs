using Microsoft.AspNetCore.Mvc;

namespace Message.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
