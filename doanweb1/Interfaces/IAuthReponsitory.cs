using doanweb1.DTO;
using doanweb1.Entities;

namespace doanweb1.Interfaces
{
    public interface IAuthReponsitory
    {
        public string getData();

        public KhachHang Login(LoginDTO login);

        public bool Register(RegisterDTO register);

        public bool Forgotpassword(ForgotPasswordDTO forgotpassword);

        public List<KhachHang> GetAllUser();

    }
}
