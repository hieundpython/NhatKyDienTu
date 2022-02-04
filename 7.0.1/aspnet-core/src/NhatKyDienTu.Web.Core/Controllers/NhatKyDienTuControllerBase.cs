using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NhatKyDienTu.Controllers
{
    public abstract class NhatKyDienTuControllerBase: AbpController
    {
        protected NhatKyDienTuControllerBase()
        {
            LocalizationSourceName = NhatKyDienTuConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
