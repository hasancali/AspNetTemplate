using Microsoft.EntityFrameworkCore;

namespace AspNetTemplate.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<AspNetTemplateDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for AspNetTemplateDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
