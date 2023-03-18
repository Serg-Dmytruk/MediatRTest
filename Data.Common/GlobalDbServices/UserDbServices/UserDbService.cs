using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Common.GlobalDbServices.UserDbServices
{
    public class UserDbService : IUserDbService
    {
        private readonly ApplicationDbContext _db;
        public UserDbService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<User>> GetAllUsers()   
            => await _db.Users.ToListAsync();
        
        public async Task<User> GetUserByUsername(string username)
            => await _db.Users.SingleOrDefaultAsync(x => x.Username == username);
    }
}
