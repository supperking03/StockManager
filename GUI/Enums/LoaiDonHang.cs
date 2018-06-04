using System.ComponentModel;

namespace GUI.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum LoaiDonHang
    {
        [Description("Trong tỉnh")]
        TrongTinh,
        [Description("Ngoài tỉnh")]
        NgoaiTinh,
        [Description("Nước ngoài")]
        NuocNgoai
    }
}
