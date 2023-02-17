using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Data.Context
{

    public class ShopBackEndContextFactory : IDesignTimeDbContextFactory<ShopBackEndContext>
    {
        public ShopBackEndContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json")
                                        .Build();



            var builder = new DbContextOptionsBuilder<ShopBackEndContext>();
            var connectionString = configuration.GetConnectionString("ShopBackEndConnectionString");

            builder.UseSqlServer(connectionString);

            return new ShopBackEndContext(builder.Options);
        }

     
    }

}
