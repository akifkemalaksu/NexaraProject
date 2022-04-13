using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryEngine _countryEngine;

        public CountryController(ICountryEngine countryEngine)
        {
            _countryEngine = countryEngine;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _countryEngine.GetCountries();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}