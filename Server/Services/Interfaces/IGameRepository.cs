using System.Threading.Tasks;
using Medieval.Shared;
using Server.Models;

namespace Server.Services.Interfaces
{
    public interface IGameRepository : IBaseRepository
    {
        Task<Game> GetGameForLoggedInUser(string user);
    }
}