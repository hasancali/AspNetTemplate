using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetTemplate.Web.Startup;
namespace AspNetTemplate.Web.Tests
{
    [DependsOn(
        typeof(AspNetTemplateWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class AspNetTemplateWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetTemplateWebTestModule).GetAssembly());
        }
    }
}