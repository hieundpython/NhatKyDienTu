using System.Collections.Generic;

namespace NhatKyDienTu.MainModel.ThongTinChung
{
    public class HienThiThongTin
    {

        private static readonly List<TextHienThi<CapBac>> listCapBac = new()
        {
            new TextHienThi<CapBac> { Text = "Thiếu úy", Value = CapBac.ThieuUy },
            new TextHienThi<CapBac> { Text = "Trung úy", Value = CapBac.TrungUy },
            new TextHienThi<CapBac> { Text = "Thượng úy", Value = CapBac.ThuongUy },
            new TextHienThi<CapBac> { Text = "Đại úy", Value = CapBac.DaiUy },
            new TextHienThi<CapBac> { Text = "Thiếu tá", Value = CapBac.ThieuTa },
            new TextHienThi<CapBac> { Text = "Trung tá", Value = CapBac.TrungTa },
            new TextHienThi<CapBac> { Text = "Thượng tá", Value = CapBac.ThuongTa },
            new TextHienThi<CapBac> { Text = "Đại tá", Value = CapBac.DaiTa },
            new TextHienThi<CapBac> { Text = "Thiếu úy CN", Value = CapBac.ThieuUyCN },
            new TextHienThi<CapBac> { Text = "Trung úy CN", Value = CapBac.TrungUyCN },
            new TextHienThi<CapBac> { Text = "Thượng úy CN", Value = CapBac.ThuongUyCN },
            new TextHienThi<CapBac> { Text = "Đại úy CN", Value = CapBac.DaiUyCN },
            new TextHienThi<CapBac> { Text = "Thiếu tá CN", Value = CapBac.ThieuTaCN },
            new TextHienThi<CapBac> { Text = "Trung tá CN", Value = CapBac.TrungTaCN },
        };

        private static readonly List<TextHienThi<ChucVu>> listChucVu = new()
        {
            new TextHienThi<ChucVu> { Text = "Lữ đoàn trưởng", Value = ChucVu.LuDoanTruong },
            new TextHienThi<ChucVu> { Text = "Chính ủy", Value = ChucVu.ChinhUy },
            new TextHienThi<ChucVu> { Text = "Phó lữ trưởng", Value = ChucVu.PhoLuTruong },
            new TextHienThi<ChucVu> { Text = "Phó chính ủy", Value = ChucVu.PhoChinhUy },
            new TextHienThi<ChucVu> { Text = "Chủ nhiệm", Value = ChucVu.ChuNhiem },
            new TextHienThi<ChucVu> { Text = "Phó chủ nhiệm", Value = ChucVu.PhoChuNhiem },
            new TextHienThi<ChucVu> { Text = "Trợ lý", Value = ChucVu.TroLy },
            new TextHienThi<ChucVu> { Text = "Tiểu đoàn trưởng", Value = ChucVu.TieuDoanTruong },
            new TextHienThi<ChucVu> { Text = "Chính trị viên tiểu đoàn", Value = ChucVu.ChinhTriVienTieuDoan },
            new TextHienThi<ChucVu> { Text = "Chính trị viên đại đội", Value = ChucVu.ChinhTriVienDaiDoi },
            new TextHienThi<ChucVu> { Text = "Đại đội trưởng", Value = ChucVu.DaiDoiTruong },
            new TextHienThi<ChucVu> { Text = "Phó đại đội trưởng", Value = ChucVu.PhoDaiDoiTruong },
            new TextHienThi<ChucVu> { Text = "Chính trị viên phó", Value = ChucVu.ChinhTriVienPho },
            new TextHienThi<ChucVu> { Text = "Trung đội trưởng", Value = ChucVu.TrungDoiTruong },
            new TextHienThi<ChucVu> { Text = "Thợ sửa chữa", Value = ChucVu.ThoSoChua },
            new TextHienThi<ChucVu> { Text = "Lái xe", Value = ChucVu.LaiXe },
            new TextHienThi<ChucVu> { Text = "Lái máy", Value = ChucVu.LaiMay },
            new TextHienThi<ChucVu> { Text = "Lái cano", Value = ChucVu.LaiCano },
            new TextHienThi<ChucVu> { Text = "Quân lực", Value = ChucVu.QuanLuc },
            new TextHienThi<ChucVu> { Text = "Vũ khí công binh", Value = ChucVu.VuKhiCongBinh },
            new TextHienThi<ChucVu> { Text = "VHENT", Value = ChucVu.VHENT },
            new TextHienThi<ChucVu> { Text = "Quản lý", Value = ChucVu.QuanLy },
            new TextHienThi<ChucVu> { Text = "Thợ xây", Value = ChucVu.ThoXay },
            new TextHienThi<ChucVu> { Text = "Lái tàu", Value = ChucVu.LaiTau },
        };

        private static readonly List<TextHienThi<DaiDoi>> listDaiDoi = new()
        {
            new TextHienThi<DaiDoi> { Text = "Đại đội 1", Value = DaiDoi.DaiDoi_1 },
            new TextHienThi<DaiDoi> { Text = "Đại đội 2", Value = DaiDoi.DaiDoi_2 },
            new TextHienThi<DaiDoi> { Text = "Đại đội 3", Value = DaiDoi.DaiDoi_3 },
            new TextHienThi<DaiDoi> { Text = "Đại đội 4", Value = DaiDoi.DaiDoi_4 },
            new TextHienThi<DaiDoi> { Text = "Đại đội 7", Value = DaiDoi.DaiDoi_7 },
            new TextHienThi<DaiDoi> { Text = "Đại đội 10", Value = DaiDoi.DaiDoi_10 },
            new TextHienThi<DaiDoi> { Text = "Đại đội 11", Value = DaiDoi.DaiDoi_11 },
            new TextHienThi<DaiDoi> { Text = "Đại đội 12", Value = DaiDoi.DaiDoi_12 },
            new TextHienThi<DaiDoi> { Text = "Đại đội 13", Value = DaiDoi.DaiDoi_13 },
        };

        private static readonly List<TextHienThi<LuDoan>> listLuDoan = new()
        {
            new TextHienThi<LuDoan> { Text = "Lữ đoàn 414", Value = LuDoan.LuDoan_414 },
        };

        private static readonly List<TextHienThi<TieuDoan>> listTieuDoan = new()
        {
            new TextHienThi<TieuDoan> { Text = "Tiểu đoàn 1", Value = TieuDoan.TieuDoan_1 },
            new TextHienThi<TieuDoan> { Text = "Tiểu đoàn 2", Value = TieuDoan.TieuDoan_2 },
            new TextHienThi<TieuDoan> { Text = "Tiểu đoàn 3", Value = TieuDoan.TieuDoan_3 },
            new TextHienThi<TieuDoan> { Text = "Tiểu đoàn 4", Value = TieuDoan.TieuDoan_4 },
        };


        public static string GetCapBac(CapBac? capBac)
        {
            var item = listCapBac.Find(e => e.Value == capBac);

            if (item != null)
            {
                return item.Text;
            }
            return "";
        }

        public static string GetChucVu(ChucVu? chucVu)
        {
            var item = listChucVu.Find(e => e.Value == chucVu);

            if (item != null)
            {
                return item.Text;
            }
            return "";
        }

        public static string GetDaiDoi(DaiDoi? daidoi)
        {
            var item = listDaiDoi.Find(e => e.Value == daidoi);

            if (item != null)
            {
                return item.Text;
            }
            return "";
        }

        public static string GetLuDoan(LuDoan? luDoan)
        {
            var item = listLuDoan.Find(e => e.Value == luDoan);

            if (item != null)
            {
                return item.Text;
            }
            return "";
        }

        public static string GetTieuDoan(TieuDoan? tieuDoan)
        {
            var item = listTieuDoan.Find(e => e.Value == tieuDoan);

            if (item != null)
            {
                return item.Text;
            }
            return "";
        }
    }

    public class TextHienThi<T>
    {
        public string Text { get; set; }

        public T Value { get; set; }
    }
}
