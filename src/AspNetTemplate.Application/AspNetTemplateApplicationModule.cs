using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspNetTemplate
{
    [DependsOn(
        typeof(AspNetTemplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AspNetTemplateApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetTemplateApplicationModule).GetAssembly());
        }
    }
}