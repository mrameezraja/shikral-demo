using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Shikral.Demo.MultiTenancy.Dto;

namespace Shikral.Demo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

