using Abp.AspNetCore.Mvc.Controllers;

namespace AspNetTemplate.Web.Controllers
{
    public abstract class AspNetTemplateControllerBase: AbpController
    {
        protected AspNetTemplateControllerBase()
        {
            LocalizationSourceName = AspNetTemplateConsts.LocalizationSourceName;
        }
    }
}