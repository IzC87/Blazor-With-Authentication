using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Medieval.Shared;
using Server.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using AutoMapper;

namespace Medieval.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("v1.0/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;
        private readonly string _userId;

        public GameController(IGameRepository gameRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper, ILogger<GameController> logger)
        {
            _gameRepository = gameRepository;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<GameModel> GetGameForLoggedInUser()
        {
            try
            {
                var game = await _gameRepository.GetGameForLoggedInUser(_userId);
                return _mapper.Map<GameModel>(game);
            }
            catch (System.Exception)
            {
                _logger.LogError("Unable to map current game model!");
                return null;
            }
        }
    }
}
