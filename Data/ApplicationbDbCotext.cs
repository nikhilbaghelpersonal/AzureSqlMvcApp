using AzureSqlMvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureSqlMvcApp.Data
{
    public class ApplicationbDbCotext: DbContext
    {
        public ApplicationbDbCotext(DbContextOptions<ApplicationbDbCotext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
