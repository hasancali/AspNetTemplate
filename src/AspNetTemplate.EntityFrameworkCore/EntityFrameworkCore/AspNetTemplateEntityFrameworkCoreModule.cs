using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspNetTemplate.EntityFrameworkCore
{
    [DependsOn(
        typeof(AspNetTemplateCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class AspNetTemplateEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetTemplateEntityFrameworkCoreModule).GetAssembly());
        }
    }
}