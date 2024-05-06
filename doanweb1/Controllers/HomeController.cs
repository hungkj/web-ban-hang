
using doanweb1.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace doanweb1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeservice;

        public HomeController(IHomeService homeService)
        {
            this._homeservice = homeService;
        }

        public IActionResult Index()
        {
            var username = HttpContext.Session.GetString("Username");
            //if(!string.IsNullOrEmpty(username) )
            //{
            //    ViewBag.Username = username;
            //    return View();
            //}
            //return RedirectToAction("Login");
            
            
          var b = _homeservice.GetSlideBar();
            //ViewBag.dulieu1 = "Đây là dữ liệu 1";   //key=dulieu1,  value = "Đây là dữ liệu 1"
            //ViewBag.dulieu2 = a;

            return View(b);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
      
    }
}
