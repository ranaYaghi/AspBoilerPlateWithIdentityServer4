using Abp.Application.Services;
using IdentityServer.MultiTenancy.Dto;

namespace IdentityServer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

