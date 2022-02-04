using System.Threading.Tasks;
using Abp.Application.Services;
using NhatKyDienTu.Authorization.Accounts.Dto;

namespace NhatKyDienTu.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
