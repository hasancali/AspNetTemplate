using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetTemplate.Configuration;
using AspNetTemplate.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace AspNetTemplate.Web.Startup
{
    [DependsOn(
        typeof(AspNetTemplateApplicationModule), 
        typeof(AspNetTemplateEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class AspNetTemplateWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetTemplateWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AspNetTemplateConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<AspNetTemplateNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AspNetTemplateApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetTemplateWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AspNetTemplateWebModule).Assembly);
        }
    }
}
