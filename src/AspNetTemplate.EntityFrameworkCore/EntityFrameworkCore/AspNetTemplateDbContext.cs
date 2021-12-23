using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetTemplate.EntityFrameworkCore
{
    public class AspNetTemplateDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public AspNetTemplateDbContext(DbContextOptions<AspNetTemplateDbContext> options) 
            : base(options)
        {

        }
    }
}
