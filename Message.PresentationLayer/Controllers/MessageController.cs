using Microsoft.AspNetCore.Mvc;

namespace Message.PresentationLayer.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult MessageList()
        {
            return View();
        }
    }
}
