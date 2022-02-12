using System.Collections.Generic;

namespace NhatKyDienTu.MainApplication.Dto
{
    public class ThongKeDto
    {
        public List<CamXuc> CamXucs { get; set; }

        public List<HashTag> HashTags { get; set; }
    }

    public class HashTagNode
    {
        public string TenHashTag { get; set; }

        public string TenCamXuc { get; set; }
    }

    public class HashTag
    {
        public string TenHashTag { get; set; }

        public List<CamXuc> ListCamXuc { get; set; }
    }

    public class CamXuc
    {
        public string TenCamXuc { get; set; }

        public int SoLuong { get; set; }
    }
}
