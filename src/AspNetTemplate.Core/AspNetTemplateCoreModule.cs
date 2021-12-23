using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetTemplate.Localization;

namespace AspNetTemplate
{
    public class AspNetTemplateCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            AspNetTemplateLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = AspNetTemplateConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetTemplateCoreModule).GetAssembly());
        }
    }
}