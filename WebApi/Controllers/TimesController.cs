using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesController : ControllerBase
    {
        private ApiDbContext _apiDbContext;
        public TimesController(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        //[HttpGet("city/{cityId}/date/{dateId}")]
        //public IActionResult GetSaatlerByTarihVeSehir(int cityId, int dateId)
        //{

        //    var saatler = _apiDbContext.Times
        //        .Where(c => c.Cities.Id == cityId && c.Dates.Id == dateId)
        //        .ToList();
        //    return Ok(saatler);
        //}

        [HttpGet]
        public IActionResult GetSaatlerByTarihVeSehir(int cityId, int dateId)
        {

            var saatler = _apiDbContext.Times
                .Where(c => c.Cities.Id == cityId && c.Dates.Id == dateId)
                .ToList();
            return Ok(saatler);
        }


    }
}
