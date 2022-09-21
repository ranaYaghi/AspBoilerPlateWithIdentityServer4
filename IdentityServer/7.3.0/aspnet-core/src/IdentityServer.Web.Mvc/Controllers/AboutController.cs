using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using IdentityServer.Controllers;

namespace IdentityServer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : IdentityServerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
