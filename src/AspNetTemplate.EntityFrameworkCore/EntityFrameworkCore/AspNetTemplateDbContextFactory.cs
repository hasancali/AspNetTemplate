using AspNetTemplate.Configuration;
using AspNetTemplate.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AspNetTemplate.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class AspNetTemplateDbContextFactory : IDesignTimeDbContextFactory<AspNetTemplateDbContext>
    {
        public AspNetTemplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AspNetTemplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(AspNetTemplateConsts.ConnectionStringName)
            );

            return new AspNetTemplateDbContext(builder.Options);
        }
    }
}