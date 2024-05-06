using doanweb1.Entities;
using doanweb1.Interfaces;
using doanweb1.Reponsitory;
using doanweb1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace doanweb1.Controllers
{
   
    public class ProductController : Controller
    {
        private readonly IProductService _productservice;
        

        public  ProductController(IProductService productservice)
        {
            this._productservice = productservice;
        }
        

        // GET: ProductController
        public ActionResult Index()
        {

            var a = _productservice.GetAllData();

            return View(a);
        }
        public ActionResult GetCard()
        {
            return View();

        }
        public ActionResult GetItem()
        {
            
            return View();

        }
        public ActionResult RemoveItem()
        {
            return View();

        }


        public ActionResult Get()
        {
            var a = _productservice.GetDataById(2);
            return View();
        }
        // GET: ProductController/Details/5
        public ActionResult GetLoaiSP()
        {
            var a = _productservice.GetLoaiSP();
            return View(a);
        }
        public ActionResult GetHinhAnh()
        {
            var image = _productservice.GetHinhAnh();
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            _productservice.AddData();
            return View();
        }

        // POST: ProductController/Create
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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
