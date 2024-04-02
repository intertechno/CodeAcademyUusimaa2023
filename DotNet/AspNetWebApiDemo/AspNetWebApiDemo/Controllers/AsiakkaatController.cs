using AspNetWebApiDemo.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsiakkaatController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Customer> HaeKaikki()
        {
            NorthwindContext context = new();
            return [..context.Customers];
            // return context.Customers.ToList();
        }
    }
}
