
using AspnetCoreMvcFull.Models;
using Microsoft.EntityFrameworkCore;

namespace Solar1.Data
{
  public class ApplicationDbContext : DbContext
  {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {


    }

    public DbSet<QuoteEntry> QuoteEntries { get; set; }

    public DbSet<StockEntry> StockEntries { get; set; }

    public DbSet<QuotePDF> QuotePDF { get; set; }

  

  }
}
