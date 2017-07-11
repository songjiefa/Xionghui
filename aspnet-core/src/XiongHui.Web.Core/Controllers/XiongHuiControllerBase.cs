using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace XiongHui.Controllers
{
    public abstract class XiongHuiControllerBase: AbpController
    {
        protected XiongHuiControllerBase()
        {
            LocalizationSourceName = XiongHuiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}