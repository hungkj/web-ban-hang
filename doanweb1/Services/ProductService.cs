using doanweb1.DTO;
using doanweb1.Entities;
using doanweb1.Interfaces;

namespace doanweb1.Services
{
    public class ProductService : IProductService
    {


        private readonly IProductReponsitory _productReponsitory;

        public ProductService(IProductReponsitory productReponsitory)
        {
            this._productReponsitory = productReponsitory;

        }

        public void AddData()
        {
            
        }
       

       

        public List<SanPham> GetDataById(int id)
        {
            return _productReponsitory.GetDataById(id);
        }

        public List<HinhAnh> GetHinhAnh()
        {
          return _productReponsitory.GetHinhAnh();
        }

        public card_item GetItem()
        {
            throw new NotImplementedException();
        }
        public List<card_item> GetCard()
        {
            throw new NotImplementedException();
        }

        public List<LoaiSanPham> GetLoaiSP()
        {
            return _productReponsitory.GetLoaiSP();
        }

        List<SanPham> IProductService.GetAllData()
        {
            return _productReponsitory.GetAllData();
        }

        public card_item RemoveItem()
        {
            throw new NotImplementedException();
        }

        
    }
}

