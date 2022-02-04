using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NhatKyDienTu.EntityFrameworkCore;
using NhatKyDienTu.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace NhatKyDienTu.Web.Tests
{
    [DependsOn(
        typeof(NhatKyDienTuWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class NhatKyDienTuWebTestModule : AbpModule
    {
        public NhatKyDienTuWebTestModule(NhatKyDienTuEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NhatKyDienTuWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NhatKyDienTuWebMvcModule).Assembly);
        }
    }
}