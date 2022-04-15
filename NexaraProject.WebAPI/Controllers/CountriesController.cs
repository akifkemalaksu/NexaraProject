using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Entities.RequestModels;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryEngine _countryEngine;

        public CountriesController(ICountryEngine countryEngine)
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

        [HttpPost]
        public IActionResult Post(AddCountryModel addCountryModel)
        {
            var result = _countryEngine.AddCountry(addCountryModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}