using System.ComponentModel;

namespace GUI.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum NgayThangNam
    {
        [Description("Ngày")]
        Ngay,
        [Description("Tháng")]
        Thang,
        [Description("Năm")]
        Nam
    }
}
