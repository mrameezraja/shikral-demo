using System.Threading.Tasks;
using Abp.Application.Services;
using Shikral.Demo.Authorization.Accounts.Dto;

namespace Shikral.Demo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
