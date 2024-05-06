using Microsoft.AspNetCore.Mvc;

namespace doanweb1.Controllers
{
    public class AccessController : Controller
    {

        [HttpGet]

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
    //    [HttpPost]
    //pblic IActionResult Login()
    //    {
    //        if (HttpContext.Session.GetString("Username") == null)
    //        {
    //            return View();
    //        }
    //        else
    //        {
    //            return RedirectToAction("Index", "Home");
    //        }

    //    }


    }
}
