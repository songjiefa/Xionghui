using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XiongHui.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace XiongHui.Web.Host.Startup
{
    [DependsOn(
       typeof(XiongHuiWebCoreModule))]
    public class XiongHuiWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public XiongHuiWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XiongHuiWebHostModule).GetAssembly());
        }
    }
}
