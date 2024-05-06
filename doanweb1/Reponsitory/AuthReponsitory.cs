using doanweb1.Interfaces;
using doanweb1.Entities;
using System.Linq.Expressions;
using doanweb1.DTO;
using Microsoft.Win32;

namespace doanweb1.Reponsitory
{
    
    public class AuthReponsitory : IAuthReponsitory
    {
        private readonly san_phamContext _dbContext;
        
        public AuthReponsitory(san_phamContext dbContext) {
            this._dbContext = dbContext;    
        
        }

        public bool Forgotpassword(ForgotPasswordDTO forgotpassword)
        {
            throw new NotImplementedException();
        }

        public List<KhachHang> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public string getData()
        {
            //lay tat ca databse
            var a = _dbContext.KhachHangs.ToList();
            //lay tung cai database
            var b = _dbContext.KhachHangs.FirstOrDefault();

            //
            var customers = _dbContext.KhachHangs.Where(k => k.Id == 2).ToList();
            
            var customer = _dbContext.KhachHangs
    .Where(k => k.Id == 2) // Lọc theo điều kiện Id = "2"
    .OrderBy(k => k.TenDangNhap) //sort theo "Name";
    .ToList();
            //
            KhachHang user = new KhachHang()
            {
                DiaChi = "",
                TenDangNhap = "am",
                Sdt = "11111111111111111111",
                Email = "a@gmail.com",
                MatKhau = "am",
                Name = "am1",
            };
            //update database
            //  _dbContext.KhachHangs.Add(user);

            //_dbContext.SaveChanges();

            //delete database
            //var d = _dbContext.KhachHangs.Where (k => k.Id == 9).FirstOrDefault();
            //_dbContext.KhachHangs.Remove(d);

            //update id 10 
            var e = _dbContext.KhachHangs.Where(k => k.Id == 10).FirstOrDefault();
            e.Name = "faffafa";
            


            _dbContext.SaveChanges();

            return "ok";
        }
        //xu ly dang nhap
        public KhachHang Login(LoginDTO login)
        {
            var k = _dbContext.KhachHangs.Where(u => u.TenDangNhap == login.Username && u.MatKhau == login.Password).FirstOrDefault();
            if (k == null)
            {
                return null;
            }
            return k ;
        }
        //xu ly dang ki
        public bool Register(RegisterDTO register)
        {
            var existingUser = _dbContext.KhachHangs
                                    .FirstOrDefault(u => u.TenDangNhap == register.Username || u.Email == register.Email);

            if (existingUser == null)
            {
                KhachHang newUser = new KhachHang()
                {
                    DiaChi = "./../...",
                    TenDangNhap = register.Username,
                    Sdt = "+09xxxxx",
                   Email = register.Email,
                    MatKhau = register.Password,
                    Name = register.Name,
                    
                };

                _dbContext.KhachHangs.Add(newUser);
                _dbContext.SaveChanges();

                    return true;
            }

            return false; // Người dùng đã tồn tại với tên đăng nhập hoặc email đã được sử dụng
        }





    }

}

