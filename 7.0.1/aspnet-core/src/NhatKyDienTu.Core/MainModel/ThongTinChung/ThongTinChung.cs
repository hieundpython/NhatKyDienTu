using Abp.Domain.Entities;
using NhatKyDienTu.Authorization.Users;

namespace NhatKyDienTu.MainModel.ThongTinChung
{
    public class ThongTinChung : Entity, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public CapBac? CapBac { get; set; }

        public ChucVu? ChucVu { get; set; }

        public DaiDoi? DaiDoi { get; set; }

        public LuDoan? LuDoan { get; set; }

        public TieuDoan? TieuDoan { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }
    }
}
