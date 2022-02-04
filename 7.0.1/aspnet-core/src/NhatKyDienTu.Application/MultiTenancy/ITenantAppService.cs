using Abp.Application.Services;
using NhatKyDienTu.MultiTenancy.Dto;

namespace NhatKyDienTu.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

