using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;
using System.Text.Json;
using WebApi.Data;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ApiDbContext _apiDbContext;
        public CitiesController(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            var cities = await (from city in _apiDbContext.Cities
                                select new
                                {
                                    Id = city.Id,
                                    CityName = city.CityName,
                                }
                ).ToListAsync();
            return Ok(cities);
        }

        //[HttpGet("[action]")]
        //public async Task<IActionResult> CityDetails(int cityId)
        //{
        //    var options = new JsonSerializerOptions
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve
        //    };

        //    var cityDetails = await _apiDbContext.Cities
        //        .Where(a => a.Id == cityId)
        //        .Include(a => a.Times).ToListAsync();
        //    return Ok(JsonSerializer.Serialize(cityDetails, options));
        //    return Ok(cityDetails);
        //}
    }
}