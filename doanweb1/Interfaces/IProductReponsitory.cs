using doanweb1.DTO;
using doanweb1.Entities;

namespace doanweb1.Interfaces
{
    public interface IProductReponsitory
    {
       
        public void AddData();
        public List<SanPham> GetAllData();

        public List<SanPham> GetDataById(int id);

        public List<LoaiSanPham> GetLoaiSP();
        public List<HinhAnh> GetHinhAnh();

        public List<card_item> GetCard();
        public card_item GetItem();

        public card_item RemoveItem();
        
        public SanPham GetspByid(int id);
    } 
}
