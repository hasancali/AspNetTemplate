using Abp.AspNetCore.Mvc.Views;

namespace AspNetTemplate.Web.Views
{
    public abstract class AspNetTemplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AspNetTemplateRazorPage()
        {
            LocalizationSourceName = AspNetTemplateConsts.LocalizationSourceName;
        }
    }
}
