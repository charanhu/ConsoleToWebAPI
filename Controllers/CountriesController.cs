using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute]int id, [FromHeader]string developer, [FromHeader]string course)
        {
            return Ok($"Name = {course}");
        }

        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))] string[] countries)
        {
            return Ok(countries);
        }

        [HttpGet("{id}")]
        public IActionResult CountryDetails([ModelBinder(Name ="Id")]CountryModel country)
        {
            return Ok(country);
        }
    }
}
