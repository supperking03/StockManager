using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using DTO;
namespace DAL
{
    public static class NhanVienDAL
    {
        public static bool ThemNhanVien(DTO.NhanVienDTO nvDTO)
        {
            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVien",nvDTO.MaNhanVien),
                    new SQLiteParameter("@TenNhanVien",nvDTO.TenNhanVien)
                };
                var n = DataAccessHelper.ExecuteNonQuery("INSERT INTO NHANVIEN VALUES(@MaNhanVien, @TenNhanVien)", parameters);
                if (n == 1)
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

        public static bool SuaNhanVien(DTO.NhanVienDTO nvDTO)
        {
            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVien",nvDTO.MaNhanVien),
                    new SQLiteParameter("@TenNhanVien",nvDTO.TenNhanVien)
                };
                var n = DataAccessHelper.ExecuteNonQuery(
                    "UPDATE NHANVIEN SET TENNHANVIEN=@TenNhanVien WHERE MaNhanVien=@MaNhanVien", parameters);
                if (n == 1)
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

        public static bool XoaMoiNhanVien()
        {
            var result = false;
            try
            {
                var n = DataAccessHelper.ExecuteNonQuery("DELETE FROM NHANVIEN");
                if (n == 1)
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

        public static bool XoaNhanVien(DTO.NhanVienDTO nvDTO)
        {
            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVien",nvDTO.MaNhanVien)
                };
                var n = DataAccessHelper.ExecuteNonQuery(
                    "DELETE FROM NHANVIEN  WHERE MaNhanVien=@MaNhanVien", parameters);
                if (n == 1)
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

        public static List<NhanVienDTO> SelectNhanVienAll()
        {
            var list = new List<NhanVienDTO>();
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("SELECT * FROM NHANVIEN ");
                list.AddRange(from DataRow dr in dt.Rows
                              select new NhanVienDTO
                              {
                                  MaNhanVien = dr["MaNhanVien"].ToString(),
                                  TenNhanVien = dr["TenNhanVien"].ToString()
                              }
                              );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static NhanVienDTO SelectNhanVienByMaNhanVien(string strMaNhanVien)
        {
            NhanVienDTO nvDTO = new NhanVienDTO();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVien",strMaNhanVien)
                };
                var dt = DataAccessHelper.ExecuteQuery
                    (
                    "SELECT MaNhanVien,TenNhanVien FROM NHANVIEN WHERE MaNhanVien=@MaNhanVien", parameters
                    );
                var dr = dt.Rows[0];
                nvDTO.MaNhanVien = dr["MaNhanVien"].ToString();
                nvDTO.TenNhanVien = dr["TenNhanVien"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nvDTO;
        }

        public static NhanVienDTO SelectNhanVienByTenNhanVien(string strTenNhanVien)
        {
            NhanVienDTO nvDTO = new NhanVienDTO();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@TenNhanVien",strTenNhanVien)
                };
                var dt = DataAccessHelper.ExecuteQuery
                    (
                    "SELECT MaNhanVien,TenNhanVien From NHANVIEN WHERE TenNhanVien=@TenNhanVien",parameters
                    );
                var dr = dt.Rows[0];
                nvDTO.MaNhanVien = dr["MaNhanVien"].ToString();
                nvDTO.TenNhanVien = dr["TenNhanVien"].ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return nvDTO;
        }


        public static bool CheckNhanVienByMaNhanVien(string strMaNhanVien)
        {
            bool result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVien",strMaNhanVien)
                };
                var dt = DataAccessHelper.ExecuteQuery(
                    "SELECT MaNhanVien From NHANVIEN WHERE MaNhanVien=@MaNhanVien", parameters
                    );
                if (dt.Rows.Count==1)
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

        public static int GenerateNewMaNhanVien()
        {
            var newMaNhanVien = 0;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    "Select MAX(CAST(REPLACE(MaNhanVien , 'NV', '') as int)) + 1 as NewMaNhanVien from NhanVien");
                newMaNhanVien = dt.Rows[0]["NewMaNhanVien"].ToString() == "" ?
                    1 :
                    int.Parse(dt.Rows[0]["NewMaNhanVien"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return newMaNhanVien;
        }
    }
}
