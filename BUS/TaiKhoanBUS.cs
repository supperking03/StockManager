using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static DTO.TaiKhoanDTO SelectTaiKhoanByTenTaiKhoan(string tenTaiKhoan)
        {
            if (!TaiKhoanDAL.CheckTaiKhoanByTenTaiKhoan(tenTaiKhoan))
            {
                return null;
            }
            else
            {
                return TaiKhoanDAL.SelectTaiKhoanByTenTaiKhoan(tenTaiKhoan);
            }
        }
    }
}
