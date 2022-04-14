﻿using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColorEngine _colorEngine;

        public ColorController(IColorEngine colorEngine)
        {
            _colorEngine = colorEngine;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _colorEngine.GetColours();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}