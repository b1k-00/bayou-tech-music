using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class JuniorAssociateDbContext : DbContext
{

    public JuniorAssociateDbContext(DbContextOptions<JuniorAssociateDbContext> options) : base(options)
    {
    }

    /// <summary>
    /// This lets us apply any custom configurations from this assembly. We want this so we can define
    /// any data definitions in a configuration file and have it applied.
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(JuniorAssociateDbContext).Assembly);
    }

    #region DbSets

    public DbSet<DadJoke> DadJokes { get; set; }

    #endregion
}
