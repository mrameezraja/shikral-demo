using Microsoft.AspNetCore.Antiforgery;
using Shikral.Demo.Controllers;

namespace Shikral.Demo.Web.Host.Controllers
{
    public class AntiForgeryController : DemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
