using Microsoft.AspNetCore.Mvc;
namespace RasuliESayHello.Controller;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase{

    [HttpGet]
    [Route("sayHello/{name}")]
    public string sayHello(string name){
        return "Hello, "+name;
    }

}