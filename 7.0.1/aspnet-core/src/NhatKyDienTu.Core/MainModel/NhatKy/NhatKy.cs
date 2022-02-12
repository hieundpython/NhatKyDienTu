using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using NhatKyDienTu.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations;

namespace NhatKyDienTu.MainModel.NhatKy
{
    public class NhatKy : Entity, IMayHaveTenant, IHasCreationTime
    {
        [MaxLength(200)]
        public string CamXuc { get; set; }

        [MaxLength(200)]
        public string HashTag { get; set; }

        public string Note { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public int? TenantId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
