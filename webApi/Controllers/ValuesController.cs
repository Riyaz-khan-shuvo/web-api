using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[Route("[action]")]
        [HttpGet]
        public string getName()
        {
            return "Hello I am Riyaz Khan Shuvo";
        }
        //[Route("[action]")]
        [HttpGet]
        public string getAddress()
        {
            return "I am coming form Chandpur!!!";
        }
    }
}
