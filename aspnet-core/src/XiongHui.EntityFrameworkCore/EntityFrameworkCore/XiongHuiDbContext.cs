using Abp.Zero.EntityFrameworkCore;
using XiongHui.Authorization.Roles;
using XiongHui.Authorization.Users;
using XiongHui.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace XiongHui.EntityFrameworkCore
{
    public class XiongHuiDbContext : AbpZeroDbContext<Tenant, Role, User, XiongHuiDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public XiongHuiDbContext(DbContextOptions<XiongHuiDbContext> options)
            : base(options)
        {

        }
    }
}
