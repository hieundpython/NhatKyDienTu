using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NhatKyDienTu.Configuration;
using NhatKyDienTu.EntityFrameworkCore;
using NhatKyDienTu.Migrator.DependencyInjection;

namespace NhatKyDienTu.Migrator
{
    [DependsOn(typeof(NhatKyDienTuEntityFrameworkModule))]
    public class NhatKyDienTuMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public NhatKyDienTuMigratorModule(NhatKyDienTuEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(NhatKyDienTuMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                NhatKyDienTuConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NhatKyDienTuMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
