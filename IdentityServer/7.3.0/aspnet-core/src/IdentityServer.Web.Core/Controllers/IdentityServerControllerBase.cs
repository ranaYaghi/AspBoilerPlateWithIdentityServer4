using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Controllers
{
    public abstract class IdentityServerControllerBase: AbpController
    {
        protected IdentityServerControllerBase()
        {
            LocalizationSourceName = IdentityServerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
