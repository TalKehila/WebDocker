using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("index")]
    public IActionResult Index()
    {
        return Content(@"
         ____ 
        /    \
       |  ()  |
        \____/




  .--------------.
  '==============='");
    }
}