using doanweb1.DTO;
using doanweb1.Entities;
using doanweb1.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace doanweb1.Controllers
{
    public class AuthController : Controller
    {
        // GET: AuthController
        private readonly IAuthService _authService;
       public AuthController(IAuthService authService) { 
            this._authService = authService;
        }
        public ActionResult Index()
        {
            LoginDTO loginDTO = new LoginDTO()
            {
                Username ="admin",
                Password ="admin",

            };
            var a = _authService.Login(loginDTO);
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginDTO login)
        {
            var khachhang = _authService.Login(login);
      
            if (khachhang != null )
            {

               HttpContext.Session.SetString("Username", login.Username);
                //HttpContext.Session.SetString("Name", 
                HttpContext.Session.SetString("AvatarUrl", "https://s.yimg.com/fz/api/res/1.2/JfL2QGh_gb8jJDGki7Pp7A--~C/YXBwaWQ9c3JjaGRkO2ZpPWZpbGw7aD0xOTI7cHhvZmY9MDtweW9mZj0wO3E9ODA7dz0xOTI-/https://s.yimg.com/zb/imgv1/acd73ec2-7d10-3be2-80c0-7239994d551b/s_500x500");
                HttpContext.Session.SetString("Name", khachhang.Name);
                return RedirectToAction("Index", "Home");
            }
            else 
            {
                ModelState.AddModelError(string.Empty, "Invalid credentials. Please try again.");

            }
            return View(login);
           

        }
        
        public ActionResult Register(RegisterDTO register)
        {
            var a = _authService.Register(register);
            if (a == false)
            
                ModelState.AddModelError(string.Empty, "ALready have this username registered");


                return View(register);
                    
        }
        public ActionResult Forgotpassword()
        {
            return View();
        }



        // GET: AuthController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
