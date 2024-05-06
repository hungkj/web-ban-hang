using doanweb1.DTO;
using doanweb1.Entities;
using doanweb1.Interfaces;
using doanweb1.Reponsitory;
using Microsoft.AspNetCore.Http;

namespace doanweb1.Services
{
    public class CardService : ICardService
    {

        private readonly IProductReponsitory _productReponsitory;
        private readonly IHttpContextAccessor _contextAccessor;
        const string key = "Cart";
        public CardService(IProductReponsitory productReponsitory, IHttpContextAccessor contextAccessor)
        {
            this._productReponsitory = productReponsitory;
            this._contextAccessor = contextAccessor;

        }
        
        
        public GioHang GetCard()
        {
            var a = _contextAccessor.HttpContext.Session.GetCustomObjectFromSession<GioHang>(key);
           return a;
            
        }

        
        public bool AddItem(int id_san_pham)
        {
            var a = _contextAccessor.HttpContext.Session.GetCustomObjectFromSession<GioHang>(key);
            var sanpham =_productReponsitory.GetspByid(id_san_pham);
            if(a==null)
            {
                a=new GioHang();

            }
            a.CardItem.Add(new card_item
            {
                //ma random
                uid = Guid.NewGuid().ToString(),
                id = sanpham.Id,
                name = sanpham.TenSp,
                image = sanpham.HinhAnhs.FirstOrDefault()?.Image,
                price = sanpham.GiaSp,


            });
            _contextAccessor.HttpContext.Session.SetObjectInSession(key,a);

            return true;
        }
        public bool RemoveItem(string uid)
        {

            var a = _contextAccessor.HttpContext.Session.GetCustomObjectFromSession<GioHang>(key);
            if (a == null)
            {
                a = new GioHang();

            }
            else
            {
                //remove item
                var b =a.CardItem.Where(a=>a.uid != uid).ToList();
                a.CardItem = b;
            }
            _contextAccessor.HttpContext.Session.SetObjectInSession(key, a);


            return true;
        }

      
    }
}
