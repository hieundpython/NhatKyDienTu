using System.Threading.Tasks;
using Abp.Application.Services;
using NhatKyDienTu.Sessions.Dto;

namespace NhatKyDienTu.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
