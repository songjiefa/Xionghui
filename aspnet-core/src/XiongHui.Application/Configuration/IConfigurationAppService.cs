using System.Threading.Tasks;
using XiongHui.Configuration.Dto;

namespace XiongHui.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}