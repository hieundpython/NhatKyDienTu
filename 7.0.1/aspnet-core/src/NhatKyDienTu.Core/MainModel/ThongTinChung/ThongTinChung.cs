using Abp.Domain.Entities;
using NhatKyDienTu.Authorization.Users;

namespace NhatKyDienTu.MainModel.ThongTinChung
{
    public class ThongTinChung : Entity, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public CapBac CapBac { get; set; }

        public string ChucVu { get; set; }

        public string ThanNhan { get; set; }

        public string Lop { get; set; }

        public string TieuDoan { get; set; }

        public string DaiDoi { get; set; }

        public User User { get; set; }
    }
}
