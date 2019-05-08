using Abp.Application.Services.Dto;

namespace Shikral.Demo.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

