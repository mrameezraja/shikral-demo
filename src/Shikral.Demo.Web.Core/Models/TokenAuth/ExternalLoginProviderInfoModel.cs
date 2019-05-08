using Abp.AutoMapper;
using Shikral.Demo.Authentication.External;

namespace Shikral.Demo.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
