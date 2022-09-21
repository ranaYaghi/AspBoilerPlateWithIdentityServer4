using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using IdentityServer.Controllers;

namespace IdentityServer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : IdentityServerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
