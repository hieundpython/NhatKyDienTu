using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NhatKyDienTu.Configuration.Dto;

namespace NhatKyDienTu.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NhatKyDienTuAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
