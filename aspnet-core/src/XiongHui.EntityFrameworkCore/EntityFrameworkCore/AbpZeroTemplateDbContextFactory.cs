using XiongHui.Configuration;
using XiongHui.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace XiongHui.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class XiongHuiDbContextFactory : IDbContextFactory<XiongHuiDbContext>
    {
        public XiongHuiDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<XiongHuiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            XiongHuiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(XiongHuiConsts.ConnectionStringName));
            
            return new XiongHuiDbContext(builder.Options);
        }
    }
}