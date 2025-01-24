using Microsoft.AspNetCore.Mvc;
using BlazorProject.Models.Models;
using System.Threading.Tasks;
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService=userService;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users=await _userService.GetUsers();
        return Ok(users);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Post(AddUpdateModel newUser)
    {
        var user = await _userService.AddUser(newUser);
        return Ok(user);
    }

    [HttpPost("login")]
    public async Task<ActionResult<User>> LogIn(LoginModel loginModel)
    {
        var user = await _userService.LoginUser(loginModel);
        if (user == null)
        {
            return Unauthorized();
        }
        return Ok(user);
    }
}