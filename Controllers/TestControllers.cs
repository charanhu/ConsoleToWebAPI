using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestControllers : ControllerBase
    {

        //adding resorces
        public string Get()
        {
            return "Hello from GET";
        }
        public string Get1()
        {
            return "Hello from GET1";
        }
    }
}
