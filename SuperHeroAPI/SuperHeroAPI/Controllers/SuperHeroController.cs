using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Entities;

namespace SuperHeroAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuperHeroController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
    {
        var heros = new List<SuperHero>()
        {
            new SuperHero()
            {   
                Id = 1,  
                Name = "Spiderman",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City",
            }
        };
        
        return Ok(heros);
    }
}