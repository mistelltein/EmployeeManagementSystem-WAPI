using ANC_WAPI_EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ANC_WAPI_EmployeeApi.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("EmployeeManagement"));
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
