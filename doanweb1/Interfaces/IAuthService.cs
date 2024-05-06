using doanweb1.DTO;
using doanweb1.Entities;

namespace doanweb1.Interfaces
{
    public interface IAuthService
    {
        public string getData();
        public KhachHang Login(LoginDTO login);
        public bool Register(RegisterDTO register);

        public List<KhachHang> GetAllUser();

       



        
    }
}
