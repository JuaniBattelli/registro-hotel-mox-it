using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using registro_hotel_mox_it.Models;

namespace registro_hotel_mox_it.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<registro_hotel_mox_it.Models.Customer> Customers { get; set; } = default!;
    }
}