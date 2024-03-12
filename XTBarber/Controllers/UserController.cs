using Microsoft.AspNetCore.Mvc;

namespace XTBarber.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult dichvu()
        {
            return View();

        }

        public ActionResult gioithieu()
        {
            return View();
        }

        public ActionResult lienhe() {

            return View();
        }

        public ActionResult thanhtoan()
        {
            return View();
        }
    }
}
