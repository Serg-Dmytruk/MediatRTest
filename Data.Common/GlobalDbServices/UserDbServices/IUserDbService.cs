using Data.Models;

namespace Data.Common.GlobalDbServices.UserDbServices
{
    public interface IUserDbService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByUsername(string username);
    }
}
