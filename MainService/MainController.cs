using Microsoft.AspNetCore.Mvc;

namespace MainService;
[Route("/api/[controller]")]
[ApiController]
public class MainController : ControllerBase
{
    [HttpGet("/hello")]
    public IActionResult Hello()
    {
        return Ok("Hello");
    }
    
    [HttpPost("/goodbye")]
    public IActionResult GoodBye()
    {
        return Ok("Good bye.");
    }
}