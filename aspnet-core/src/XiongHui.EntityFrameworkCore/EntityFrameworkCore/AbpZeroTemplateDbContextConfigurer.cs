using Microsoft.EntityFrameworkCore;

namespace XiongHui.EntityFrameworkCore
{
    public static class XiongHuiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<XiongHuiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}