using doanweb1.DTO;
using doanweb1.Entities;
using doanweb1.Interfaces;
using doanweb1.Services;
using Microsoft.EntityFrameworkCore;

namespace doanweb1.Reponsitory
{
    public class ProductReponsitory : IProductReponsitory
    {
        private readonly san_phamContext _dbContext;

        public ProductReponsitory(san_phamContext dbContext)
        {
            this._dbContext = dbContext;

        }
        public void AddData()
        {
            SanPham sp = new SanPham()
            {
                TenSp = "ao so mi",
                LoaiSp = 1,
                Chitietsanpham = "ao so mi mau xanh",

            };
            _dbContext.SanPhams.Add(sp);
            _dbContext.SaveChanges();
            

   
        }

        public List<SanPham> GetAllData()
        {
           var a = _dbContext.SanPhams.Include(a =>a.HinhAnhs).ToList();
            return a;
        }

       
        public List<SanPham> GetDataById(int id)
        {
            var a =_dbContext.SanPhams.Where(s=>s.LoaiSp == id).ToList();
            return a;
        }

        public List<HinhAnh> GetHinhAnh()
        {
            var image = _dbContext.HinhAnhs.ToList();
            return image;
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
           var a =_dbContext.LoaiSanPhams.ToList();
            return a;
        }

        public card_item RemoveItem()
        {
            throw new NotImplementedException();
        }

        public SanPham GetspByid(int id)
        {
            return _dbContext.SanPhams.Where(a => a.Id == id).Include(a => a.HinhAnhs).FirstOrDefault();
        }
    }
}
