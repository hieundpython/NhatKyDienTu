using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NhatKyDienTu.Configuration;

namespace NhatKyDienTu.Web.Host.Startup
{
    [DependsOn(
       typeof(NhatKyDienTuWebCoreModule))]
    public class NhatKyDienTuWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NhatKyDienTuWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NhatKyDienTuWebHostModule).GetAssembly());
        }
    }
}
