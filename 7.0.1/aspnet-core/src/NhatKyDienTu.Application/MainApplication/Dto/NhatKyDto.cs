using Abp.Application.Services.Dto;
using System;

namespace NhatKyDienTu.MainApplication.Dto
{
    public class NhatKyDto : EntityDto
    {
        public long UserId { get; set; }

        public string CamXuc { get; set; }

        public string HashTag { get; set; }

        public string Note { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
