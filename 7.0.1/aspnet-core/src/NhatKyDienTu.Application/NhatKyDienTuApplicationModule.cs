using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NhatKyDienTu.Authorization;

namespace NhatKyDienTu
{
    [DependsOn(
        typeof(NhatKyDienTuCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NhatKyDienTuApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NhatKyDienTuAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NhatKyDienTuApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
