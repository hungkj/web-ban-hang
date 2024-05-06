using doanweb1.DTO;
using doanweb1.Entities;
using doanweb1.Interfaces;

namespace doanweb1.Reponsitory
{
    public class CartReponsitory : ICardReponsitory
    {
        private readonly san_phamContext _dbContext;
        public CartReponsitory(san_phamContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public List<card_item> GetCard()
        {
            throw new NotImplementedException();
        }

        public bool AddItem()
        {
            throw new NotImplementedException();
        }

        public bool RemoveItem()
        {
            throw new NotImplementedException();
        }
    }
}
