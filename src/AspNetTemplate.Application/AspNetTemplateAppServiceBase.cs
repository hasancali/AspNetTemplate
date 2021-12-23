using Abp.Application.Services;

namespace AspNetTemplate
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AspNetTemplateAppServiceBase : ApplicationService
    {
        protected AspNetTemplateAppServiceBase()
        {
            LocalizationSourceName = AspNetTemplateConsts.LocalizationSourceName;
        }
    }
}