using doanweb1.DTO;
using doanweb1.Entities;

namespace doanweb1.Interfaces
{
    public interface IProductService
    {
        
        public void AddData();
        public List<SanPham> GetAllData();

        public List<SanPham> GetDataById(int id);
        public List<LoaiSanPham> GetLoaiSP();
        public List<HinhAnh> GetHinhAnh();

        

    }
}
