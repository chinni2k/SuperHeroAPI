using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WelcomeAPI.Models;

namespace WelcomeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetALl()
        {
            return new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "SpiderMan",
                    FirstName="Peter",
                    LastName="Parker",
                    Place="New_York"
                }
            };

        }
    }
}
