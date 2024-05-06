using doanweb1.Entities;
using doanweb1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace doanweb1.Reponsitory
{
    public class HomeReponsitory:IHomeReponsitory
    {
        private readonly san_phamContext _dbContext;
        public HomeReponsitory(san_phamContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public List<SlideBar> GetSlideBar() {
            var a = _dbContext.SlideBars.Where(s=>s.Active==1).ToList();
            return a;
        
        }
    }
}
