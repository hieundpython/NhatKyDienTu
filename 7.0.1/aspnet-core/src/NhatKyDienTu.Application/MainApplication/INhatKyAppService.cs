using Abp.Application.Services;
using NhatKyDienTu.MainApplication.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NhatKyDienTu.MainApplication
{
    public interface INhatKyAppService : IApplicationService
    {
        Task<NhatKyDto> AddNhatKy(CreateNhatKyDto input);

        Task<List<NhatKyDto>> GetAllNhatKy(InputNhatKyDto input);

        Task<NhatKyDto> GetNhatKy(long id);

        Task<List<NhatKyDto>> GetNhatKyByUserId(long userId);
    }
}
