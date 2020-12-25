using System.Linq;
using System.Threading.Tasks;
using Medieval.Server.Data;
using Medieval.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Server.Models;
using Server.Services.Interfaces;

namespace Server.Services
{
    public class GameRepository : BaseRepository, IGameRepository
    {
        public GameRepository(MedievalContext context, ILogger<BaseRepository> logger) : base(context, logger)
        {
        }

        public async Task<Game> GetGameForLoggedInUser(string userId)
        {
            try
            {
                return await _medievalContext.Games.Include(z => z.Resources).FirstAsync(x => x.UserId == userId);
            }
            catch (System.Exception)
            {
                _logger.LogCritical($"Unable to get game for user with ID: {userId}: Database failure or user doesn't have a game");
                return null;
            }
        }
    }
}