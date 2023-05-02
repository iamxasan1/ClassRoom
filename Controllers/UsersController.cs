using Microsoft.AspNetCore.Mvc;

namespace ClassRoom.Controllers;

public class UsersController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return Ok();
    }
    
    public IActionResult SignIn()
    {
        return Ok();
    }
    
    public IActionResult Profile()
    {
        return Ok();
    }
}
