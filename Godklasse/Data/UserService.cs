// UserService.cs
using Microsoft.EntityFrameworkCore;

namespace Godklasse.Data
{
    public class UserService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Liste af Users
        public async Task<List<User>> GetAllUsers()
        {
            return await _applicationDbContext.Users.ToListAsync();
        }

        // Tilføj ny User
        public async Task<bool> InsertUser(User user)
        {
            await _applicationDbContext.Users.AddAsync(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }


        //Få User via Id 
        public async Task<User> GetUserById(int id)
        {
            User user = await _applicationDbContext.Users.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return user;
        }

        //Opdater User
        public async Task<bool> UpdateUser(User user)
        {
            _applicationDbContext.Users.Update(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Slet User
        public async Task<bool> DeleteUser(User user)
        {
            _applicationDbContext.Users.Remove(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}

