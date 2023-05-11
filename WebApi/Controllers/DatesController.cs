using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        private ApiDbContext _apiDbContext;
        public DatesController(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetDates()
        {
            var dates = await (from date in _apiDbContext.Dates
                               select new
                               {
                                   Id = date.Id,
                                   Date = date.Date,
                               }
                ).ToListAsync();
            return Ok(dates);
        }
    }
}
