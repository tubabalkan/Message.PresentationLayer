using Microsoft.AspNetCore.Mvc;

namespace Message.PresentationLayer.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult MessageList()
        {
            return View();
        }
        public IActionResult GelenKutusu()
        {
            return View();
        }
        public IActionResult GidenKutusu()
        {
            return View();
        }
        public IActionResult Onemli()
        {
            return View();
        }
        public IActionResult CopKutusu()
        {
            return View();
        }
    }
}
