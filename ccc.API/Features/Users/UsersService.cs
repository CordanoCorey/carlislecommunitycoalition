using ccc.Entity.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccc.API.Features.Users
{
    public interface IUsersService
    {
        IEnumerable<UserModel> GetUsers();
        UserModel GetUser(int id);
        UserModel GetUserByEmail(string email);
        UserModel InsertUser(UserModel model);
        UserModel UpdateUser(UserModel model);
        int InsertOrUpdateUser(int userId, string email, string phoneNumber);
        void DeleteUser(int id);
        UserModel GetUserModelFromUser(ApplicationUser user);
    }

    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _repo;

        public UsersService(IUsersRepository repo)
        {
            _repo = repo;
        }

        public void DeleteUser(int id)
        {
            _repo.Delete(id);
        }
        public UserModel GetUserModelFromUser(ApplicationUser user)
        {
            return new UserModel()
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PasswordResetCode = user.PasswordResetCode
            };
        }

        public UserModel GetUser(int id)
        {
            return _repo.FindByKey(id);
        }

        public IEnumerable<UserModel> GetUsers()
        {
            List<UserModel> users = _repo.All().ToList();
            return users;
        }

        public UserModel InsertUser(UserModel model)
        {
            var inserted = _repo.Insert(model);
            return GetUser(inserted.Id);
        }

        public UserModel UpdateUser(UserModel model)
        {
            var updated = _repo.Update(model);
            return GetUser(updated.Id);
        }

        public UserModel GetUserByEmail(string email)
        {
            return _repo.FindUserByEmail(email);
        }

        public int InsertOrUpdateUser(int userId, string email, string phoneNumber)
        {
            var existing = GetUserByEmail(email);
            if (existing != null)
            {
                return existing.Id;
            }
            var user = new UserModel
            {
                Email = email,
                NormalizedEmail = email,
                NormalizedUserName = email,
                UserName = email,
                PhoneNumber = phoneNumber,
                CreatedById = userId,
                CreatedDate = DateTime.Now,
                LastModifiedById = userId,
                LastModifiedDate = DateTime.Now,
                FirstName = "",
                LastName = "",
                AccessFailedCount = 0,
                ConcurrencyStamp = "f605120f-716d-40c3-9dbd-8ff473410823",
                EmailConfirmed = false,
                LockoutEnabled = false,
                PasswordHash = "AQAAAAEAACcQAAAAELOBJuVxexUotv2KcwjrXvL1y7w0fqQDt0OZqrA9SBRw2KUWbDCzhlJPFU7Y7P+u7Q==",
                SecurityStamp = "dfafd561-8cef-40ad-8c7a-339dc67529d0"
            };
            return InsertUser(user).Id;
        }
    }
}
