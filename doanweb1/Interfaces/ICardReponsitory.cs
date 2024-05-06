using doanweb1.DTO;

namespace doanweb1.Interfaces
{
    public interface ICardReponsitory
    {
        public List<card_item> GetCard();
        public bool AddItem();
        public bool RemoveItem();

    }
}
