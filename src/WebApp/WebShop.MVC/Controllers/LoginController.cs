using Microsoft.AspNetCore.Mvc;
using WebShop.MVC.Models;

namespace WebShop.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(LoginViewModel loginViewModel)
        {
            return View(loginViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid is false)
            {
                return View("Index", loginViewModel);
            } 

            return RedirectToAction("Index", "Home");
        }
    }
}
