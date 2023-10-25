using Search.API.Models;

namespace API.Services.Interfaces
{
    /// <summary>
    /// This user service has methods like search etc
    /// </summary>
    public interface IUserService
    {
        IEnumerable<User> SearchUser(string searchStr);
    }
}