using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IdentityServer.EntityFrameworkCore;
using IdentityServer.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace IdentityServer.Web.Tests
{
    [DependsOn(
        typeof(IdentityServerWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class IdentityServerWebTestModule : AbpModule
    {
        public IdentityServerWebTestModule(IdentityServerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IdentityServerWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(IdentityServerWebMvcModule).Assembly);
        }
    }
}