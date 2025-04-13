using Microsoft.AspNetCore.Mvc;

namespace Group16_COMP367Project.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }
    }
}
