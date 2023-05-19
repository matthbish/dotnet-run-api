using Microsoft.EntityFrameworkCore;

namespace RunApi.Models;

public class RunContext : DbContext
{
    public RunContext(DbContextOptions<RunContext> options)
        : base(options)
    {
    }

    public DbSet<Run> Runs { get; set; } = null!;
}