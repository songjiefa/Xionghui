using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using XiongHui.Roles.Dto;
using XiongHui.Users.Dto;

namespace XiongHui.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}