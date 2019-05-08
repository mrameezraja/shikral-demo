using System.Threading.Tasks;
using Shikral.Demo.Configuration.Dto;

namespace Shikral.Demo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
