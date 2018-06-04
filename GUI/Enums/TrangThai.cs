using System.ComponentModel;

namespace GUI.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum TrangThai
    {
        [Description("Đã xác nhận")]
        DaXacNhan,
        [Description("Đã nhận hàng")]
        DaNhanHang,
        [Description("Đã giao hàng")]
        DaGiaoHang,
        [Description("Đã hủy")]
        DaHuy
    }
}
