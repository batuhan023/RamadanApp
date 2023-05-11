using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Dates> Dates { get; set; }
        public DbSet<Times> Times { get; set; }


    }

}
