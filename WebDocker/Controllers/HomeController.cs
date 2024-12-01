using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("index")]
    public IActionResult Index()
    {
        return Content("Hello from HomeController! this project on github action and work with docker \n Console.WriteLine(@\"\r\n       .\r\n      \":\"\r\n    ___:____     |\"\\/\"|\r\n  ,'        `.    \\  /\r\n  |  O        \\___/  |\r\n~^~^~^~^~^~^~^~^~^~^~^~^~\");");
    }
}

