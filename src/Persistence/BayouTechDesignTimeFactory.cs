using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Persistence;

public class BayouTechDesignTimeFactory : IDesignTimeDbContextFactory<BayouTechDbContext>
{
    public BayouTechDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile(Directory.GetCurrentDirectory() + "/dbsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("BayouTechMusicDb");

        var builder = new DbContextOptionsBuilder<BayouTechDbContext>();
        builder.UseSqlServer(connectionString);

        return new BayouTechDbContext(builder.Options);
    }
}
