using NhatKyDienTu.MainModel.ThongTinChung;
using System;

namespace NhatKyDienTu.MainApplication.Dto
{
    public class InputNhatKyDto
    {
        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        //TODO: Pham vi
        public TieuDoan? TieuDoan { get; set; }

        public DaiDoi? DaiDoi { get; set; }
    }
}
