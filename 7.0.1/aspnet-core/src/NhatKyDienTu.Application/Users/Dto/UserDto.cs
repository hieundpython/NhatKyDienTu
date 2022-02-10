using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using NhatKyDienTu.Authorization.Users;
using NhatKyDienTu.MainModel.ThongTinChung;

namespace NhatKyDienTu.Users.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserDto : EntityDto<long>
    {
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxSurnameLength)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        public bool IsActive { get; set; }

        public string FullName { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime CreationTime { get; set; }

        public string[] RoleNames { get; set; }

        // Thong Tin Chung
        public CapBac? CapBac { get; set; }

        public ChucVu? ChucVu { get; set; }

        public DaiDoi? DaiDoi { get; set; }

        public LuDoan? LuDoan { get; set; }

        public TieuDoan? TieuDoan { get; set; }
    }
}
