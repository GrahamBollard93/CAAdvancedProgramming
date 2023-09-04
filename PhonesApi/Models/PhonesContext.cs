using Microsoft.EntityFrameworkCore;
using PhonesApi.Models;

namespace PhonesApi.Models;

public class PhonesContext : DbContext
{
    public PhonesContext(DbContextOptions<PhonesContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;
}