using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MilitaryStore.Models
{
    public class DesignTimeDbContextFactoryIdentity : IDesignTimeDbContextFactory<AppIdentityDbContext>
    {
        public AppIdentityDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<AppIdentityDbContext>();
            var connectionString = configuration["Data:MilitaryStoreIdentity:ConnectionString"];
            builder.UseSqlServer(connectionString);
            return new AppIdentityDbContext(builder.Options);
        }
    }
}
