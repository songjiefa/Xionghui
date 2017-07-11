using Abp.Application.Services;
using Abp.Application.Services.Dto;
using XiongHui.MultiTenancy.Dto;

namespace XiongHui.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
