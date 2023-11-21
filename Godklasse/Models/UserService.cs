// UserService.cs
using DatingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp.Services
{
    public class UserService
    {
        private List<User> users = new List<User>
        {
            new User { UserId = 1, UserName = "User1", Password = "123" }
        };

        public List<User> GetUsers()
        {
            return users;
        }

        public void CreateUser(User newUser)
        {
            newUser.UserId = users.Count + 1;
            users.Add(newUser);
        }

        public void UpdateUser(User updatedUser)
        {
            var existingUser = users.FirstOrDefault(u => u.UserId == updatedUser.UserId);
            if (existingUser != null)
            {
                existingUser.UserName = updatedUser.UserName;
                existingUser.Password = updatedUser.Password;
            }
        }

        public void DeleteUser(int userId)
        {
            var userToDelete = users.FirstOrDefault(u => u.UserId == userId);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);
            }
        }
    }
}
