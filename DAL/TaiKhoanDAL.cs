using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public static TaiKhoanDTO SelectTaiKhoanByTenTaiKhoan(string tenTaiKhoan)
        {
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@TenTaiKhoan", tenTaiKhoan)
                };
                var dt = DataAccessHelper.ExecuteQuery
                (
                    "SELECT * FROM TAIKHOAN WHERE TenTaiKhoan=@TenTaiKhoan", parameters
                );
                var dr = dt.Rows[0];
                taiKhoan.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
                taiKhoan.MatKhau = dr["MatKhau"].ToString();
                taiKhoan.LoaiTaiKhoan = dr [ "LoaiTaiKhoan" ].ToString ( );
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return taiKhoan;
        }

        public static bool CheckTaiKhoanByTenTaiKhoan(string tenTaiKhoan)
        {
            bool result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@TenTaiKhoan", tenTaiKhoan)
                };
                var dt = DataAccessHelper.ExecuteQuery
                (
                    "SELECT * FROM TAIKHOAN WHERE TenTaiKhoan=@TenTaiKhoan"
                    , parameters
                );
                if (dt.Rows.Count == 1)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
