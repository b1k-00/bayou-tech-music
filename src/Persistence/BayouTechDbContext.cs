﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class BayouTechDbContext : DbContext
{

    public BayouTechDbContext(DbContextOptions<BayouTechDbContext> options) : base(options)
    {
    }

    /// <summary>
    /// This lets us apply any custom configurations from this assembly. We want this so we can define
    /// any data definitions in a configuration file and have it applied.
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BayouTechDbContext).Assembly);
    }

    #region DbSets

    public DbSet<Song> Songs { get; set; }

    public DbSet<Artist> Artists { get; set; }

    public DbSet<Album> Albums { get; set; }

    public DbSet<MusicLabel> MusicLabels { get; set; }

    #endregion
}
