using Abp.Authorization;
using XiongHui.Authorization.Roles;
using XiongHui.Authorization.Users;

namespace XiongHui.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
