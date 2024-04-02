using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestiController : ControllerBase
    {
        [HttpGet]
        [Route("moi")]
        public string[] SanoMoi()
        {
            return ["Moi!", "Terve!"];
        }
    }
}
