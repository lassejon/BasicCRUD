using Api.Models;
using Microsoft.EntityFrameworkCore;
using  Microsoft.Extensions.Configuration;

namespace Api.DbContext;

public class KoiDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public KoiDbContext()
    {
  
    }

    public KoiDbContext(DbContextOptions<KoiDbContext> options)
        : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(WebApplication.CreateBuilder().Configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
    
    //entities
    public DbSet<Koi> Kois { get; set; }
} 