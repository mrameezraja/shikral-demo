using System.Threading.Tasks;
using Abp.Application.Services;
using Shikral.Demo.Sessions.Dto;

namespace Shikral.Demo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
