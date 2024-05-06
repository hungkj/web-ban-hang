using doanweb1.DTO;

namespace doanweb1.Interfaces
{
    public interface ICardService
    {
        public GioHang GetCard();
        public bool AddItem(int id_san_pham);
        public bool RemoveItem(string id_san_pham);

    }
}
