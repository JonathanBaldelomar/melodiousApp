using MelodiousApp.DataTrasfer;
using MelodiousApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiousApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet()]
        public async Task<ActionResult<List<UserDto>>> GetUsers()
        {
            try
            {
                var users = await _userService.GetAll();
                return Ok(users);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> AddNewUser([FromBody] UserDto user)
        {
            try
            {
                var newId = await _userService.AddNew(user);
                var anonymouseResponse = new
                {
                    newId
                };
                return Ok(anonymouseResponse);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateUser([FromBody] UserDto user)
        {
            try
            {
                var userUdpated = await _userService.Update(user);
                return Ok(userUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}