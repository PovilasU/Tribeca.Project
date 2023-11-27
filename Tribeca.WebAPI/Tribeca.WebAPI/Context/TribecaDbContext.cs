using Microsoft.EntityFrameworkCore;
using Tribeca.WebAPI.Entities;

namespace Tribeca.WebAPI.Context
{
    public class TribecaDbContext:DbContext
    {
        public TribecaDbContext(DbContextOptions options) : base(options) { }

        public DbSet <Employee> Employees { get; set; }
    }
}
