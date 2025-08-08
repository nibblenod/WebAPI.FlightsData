using Microsoft.EntityFrameworkCore;
using WebAPI.FlightsData.Models;

namespace WebAPI.FlightsData.Data;

public class FlightsDbContext: DbContext
{
    public FlightsDbContext(DbContextOptions options) : base(options)
    {
            
    }
    
    public DbSet<Flight> Flights { get; set; }
}