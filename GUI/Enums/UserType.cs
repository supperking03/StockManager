using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum UserType
    {
        [Description("Giám đốc")]
        GiamDoc,
        [Description("Nhân viên")]
        NhanVien,
        [Description("Khách")]
        Khach
    }
}
