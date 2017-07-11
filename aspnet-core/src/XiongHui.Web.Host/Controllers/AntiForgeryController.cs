using XiongHui.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace XiongHui.Web.Host.Controllers
{
    public class AntiForgeryController : XiongHuiControllerBase
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