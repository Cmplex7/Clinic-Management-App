using Entities;
using DAL;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class UserService
    {
        private readonly ClinicDbContext _context;

        public UserService()
        {
            _context = new ClinicDbContext();
        }
        public User Login(string username, string password)
        {
            return _context.Users.Include(u => u.Role).FirstOrDefault(u => u.UserName == username && u.Password == password);
        }

        //Lấy tất cả nhân viên
        public List<User> GetAllUser(bool showStopped = false)
        {
            if(showStopped)
                return _context.Users.ToList();
            else
                return _context.Users.Where(u => u.IsActive == true).ToList();
        }


        //Lấy danh sách bác sĩ
        public List<User> GetActiveDoctors()
        {
            return _context.Users
                .Where(u => u.RoleID == 2 && u.IsActive == true)
                .ToList();
        }

        //Lấy danh sách phân quyền
        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        //Thêm nhân viên
        public void AddUser(User user)
        {
            if(_context.Users.Any(u => u.UserName == user.UserName))
            {
                throw new System.Exception("Tên đăng nhập đã tồn tại !");
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                user.Password = "123";
            }
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        //Cập nhật nhân viên
        public void UpdateUser(User user)
        {
            var existing = _context.Users.Find(user.UserID);
            if (existing != null)
            {
                existing.FullName = user.FullName;
                existing.UserName = user.UserName;
                existing.RoleID = user.RoleID;

                if(!string.IsNullOrEmpty(user.Password))
                    existing.Password = user.Password;

                _context.SaveChanges();
            }
        }

        //Xóa nhân viên
        public void SetUserStatus(int id, bool isActive)
        {
            var user = _context.Users.Find(id);
            if(user != null)
            {
                user.IsActive = isActive;
                _context.SaveChanges();
            }
        }

        public List<User> SearchUsers(string keyword)
        {
            return _context.Users
                .Include(u => u.Role)
                .Where(u => u.FullName.Contains(keyword) || u.UserName.Contains(keyword))
                .ToList();
        }

        public void ResetPassword(int userId)
        {
            var user = _context.Users.Find(userId);
            if(user != null)
            {
                user.Password = "123";
                _context.SaveChanges();
            }
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var user = _context.Users.Find(userId);
            if(user == null)
            {
                throw new Exception("Không tìm thấy tài khoản !");
            }

            if(user.Password != oldPassword)
            {
                throw new Exception("Mật khẩu cũ không chính xác !");
            }
            user.Password = newPassword;
            _context.SaveChanges();
        }
    }
}
