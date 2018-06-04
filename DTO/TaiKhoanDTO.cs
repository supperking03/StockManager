using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public TaiKhoanDTO ( )
        {
            TenTaiKhoan = "";
            MatKhau = "";
            LoaiTaiKhoan = "";
        }
        
        public string TenTaiKhoan
        {
            get;
            set;
        }

        public string MatKhau
        {
            get;
            set;
        }

        public string LoaiTaiKhoan
        {
            get;
            set;
        }
    }
}
