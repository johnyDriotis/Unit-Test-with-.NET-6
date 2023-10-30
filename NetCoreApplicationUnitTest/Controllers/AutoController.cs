using Microsoft.AspNetCore.Mvc;
using NetCoreApplicationUnitTest.Services;

namespace NetCoreApplicationUnitTest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AutoController : ControllerBase
    {
        private readonly IAutoService _autoService;

        public AutoController(IAutoService beerService)
        {
            this._autoService = beerService;
        }

        [HttpGet]
        public IActionResult GetAutos() => Ok(_autoService.GetAutos());

        [HttpGet("{IdAuto}")]
        public IActionResult GetAutoById(int IdAuto) {

            var result = _autoService.GetAuto(IdAuto);

            if (result == null)
            {
                return NotFound();
            }
            else {
                return Ok(result);
            }
        }
    }
}