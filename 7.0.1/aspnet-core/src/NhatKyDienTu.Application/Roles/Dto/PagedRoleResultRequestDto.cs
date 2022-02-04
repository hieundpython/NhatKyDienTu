using Abp.Application.Services.Dto;

namespace NhatKyDienTu.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

