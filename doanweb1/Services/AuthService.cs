using doanweb1.DTO;
using doanweb1.Entities;
using doanweb1.Interfaces;

namespace doanweb1.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthReponsitory _authReponsitory;
       
        public AuthService(IAuthReponsitory authReponsitory)
        {
            this._authReponsitory = authReponsitory;
            
        }

        public List<KhachHang> GetAllUser()
        {
           return _authReponsitory.GetAllUser();
        }

        public string getData()
        {
            return _authReponsitory.getData();
        }

        public KhachHang Login(LoginDTO login)
        {
            return _authReponsitory.Login(login);
        }

        public bool Register(RegisterDTO register)
        {
            return _authReponsitory.Register(register);
        }
    }
}
