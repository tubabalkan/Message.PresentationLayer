using Message.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Message.PresentationLayer.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageBoxService _MessageBoxService;

        public MessageController(IMessageBoxService messageBoxService)
        {
            _MessageBoxService = messageBoxService;
        }

        public IActionResult MessageList()
        {
            var messages = _MessageBoxService.TGetListAll();
            return View(messages);
        }
        public IActionResult MessageDetail(int id)
        {
            var message = _MessageBoxService.TGetById(id);
            return View(message);
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
        public IActionResult YeniMesaj()
        {
            return View();
        }
    }
}
