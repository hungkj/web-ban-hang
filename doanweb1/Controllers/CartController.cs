using doanweb1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace doanweb1.Controllers
{
    public class CartController : Controller
    {
        private readonly ICardService _cardService;
         public CartController(ICardService cardService)
        {
            this._cardService = cardService;
        }
        public ActionResult Index()
        {
            var a = _cardService.GetCard();
            return View(a);
        }

        [HttpPost]

        public ActionResult AddItem(int id) {

            var a =_cardService.AddItem(id);
            return Ok();
     
        
        }

        [HttpPost]

        public ActionResult RemoveItem(string uid)
        {

            var a = _cardService.RemoveItem(uid);
           
            return Ok();
        }
    }

}
