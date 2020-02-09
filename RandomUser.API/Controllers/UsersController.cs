using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomUser.Data;
using RandomUser.Data.Persistence;
using RandomUser.Data.Repository.Services;

namespace RandomUser.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserApiService _userApiService;
        private readonly IUserPersistenceService _userService;
        private readonly ILogger _logger;

        public UsersController(IUserApiService userAPIService, IUserPersistenceService userService, ILogger<UsersController> logger)
        {
            _userApiService = userAPIService;
            _userService = userService;
            _logger = logger;
        }

        [Route("create")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var users = await _userApiService.GetUsers();
            await _userService.CreateUsers(users);
            return CreatedAtAction(nameof(Get), new StatusMessage { Error = false });
        }

        [Route("get")]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.GetUsers();
            if (users == null)
                return BadRequest(new StatusMessage { Error = true, Message = "There is something wrong with your request", Value = "" });
            return Ok(new StatusMessage { Error = false, Message = "", Value = users });
        }
    }
}
