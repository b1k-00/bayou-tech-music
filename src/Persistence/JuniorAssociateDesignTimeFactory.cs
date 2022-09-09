using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Persistence;

public class JuniorAssociateDesignTimeFactory : IDesignTimeDbContextFactory<JuniorAssociateDbContext>
{
    public JuniorAssociateDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile(Directory.GetCurrentDirectory() + "/dbsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("JuniorAssociateDb");

        var builder = new DbContextOptionsBuilder<JuniorAssociateDbContext>();
        builder.UseSqlServer(connectionString);

        return new JuniorAssociateDbContext(builder.Options);
    }
}
