using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using XiongHui.Configuration.Dto;

namespace XiongHui.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : XiongHuiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
