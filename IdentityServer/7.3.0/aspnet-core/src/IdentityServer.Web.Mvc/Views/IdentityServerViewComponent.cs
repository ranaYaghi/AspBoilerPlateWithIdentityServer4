using Abp.AspNetCore.Mvc.ViewComponents;

namespace IdentityServer.Web.Views
{
    public abstract class IdentityServerViewComponent : AbpViewComponent
    {
        protected IdentityServerViewComponent()
        {
            LocalizationSourceName = IdentityServerConsts.LocalizationSourceName;
        }
    }
}
