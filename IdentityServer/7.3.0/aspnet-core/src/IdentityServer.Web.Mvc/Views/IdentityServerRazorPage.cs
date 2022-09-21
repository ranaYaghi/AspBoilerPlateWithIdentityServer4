using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace IdentityServer.Web.Views
{
    public abstract class IdentityServerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected IdentityServerRazorPage()
        {
            LocalizationSourceName = IdentityServerConsts.LocalizationSourceName;
        }
    }
}
