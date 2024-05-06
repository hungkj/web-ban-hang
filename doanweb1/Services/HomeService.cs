using doanweb1.Entities;
using doanweb1.Interfaces;

namespace doanweb1.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeReponsitory _homeReponsitory;
        public HomeService(IHomeReponsitory homeReponsitory)
        {
            this._homeReponsitory = homeReponsitory;
        }

        public List<SlideBar> GetSlideBar()
        {
           return _homeReponsitory.GetSlideBar();
        }
    }
}
