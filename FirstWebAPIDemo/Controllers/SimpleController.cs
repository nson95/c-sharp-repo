using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
namespace FirstWebAPIDemo.Controllers
{
    [Route("api/Hello-World")]
    [ApiController]
    public class SimpleController : ControllerBase
    {
        private static List<string> names = new List<string>(); 
        [HttpGet("a")]
        // from example in book pg 51
        public string HelloWorld()
        {
            return "Hello World";
        }
        [HttpGet("b")]
        public string HelloWorld2()
        {
            return "Goodbye world";
        }
        [HttpGet("add-name/{name}")]
        public string AddName(string name)
        {
            names.Add(name);
            return $"{name} added";
        }

        [HttpGet("say-hello/{message}")]
        public string SayHello(string message)
        {
            return $"Hello {message}";
        }
    }
}
