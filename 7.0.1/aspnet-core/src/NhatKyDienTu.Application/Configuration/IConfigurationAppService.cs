using System.Threading.Tasks;
using NhatKyDienTu.Configuration.Dto;

namespace NhatKyDienTu.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
