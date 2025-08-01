using Microsoft.EntityFrameworkCore;
using HelloWorldApi.Models;

namespace HelloWorldApi.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options) { }

        public DbSet<YourModel> YourModels { get; set; }
    }
}

