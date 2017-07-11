using System.Threading.Tasks;
using Abp.Application.Services;
using XiongHui.Authorization.Accounts.Dto;

namespace XiongHui.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
