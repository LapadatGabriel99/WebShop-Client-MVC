using Microsoft.AspNetCore.Mvc;
using WebShop.MVC.Models;

namespace WebShop.MVC.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ILogger<RegisterController> _logger;

        public RegisterController(ILogger<RegisterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(RegisterViewModel registerViewModel)
        {
            return View(registerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid is false)
            {
                return View("Index", registerViewModel);
            }

            return RedirectToAction("Index", "Login");
        }
    }
}
