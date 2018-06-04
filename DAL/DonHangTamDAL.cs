using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public static class DonHangTamDAL
    {
        public static bool ThemDonHangTam(DTO.DonHangTamDTO dhtDTO)
        {

            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHangTam",dhtDTO.MaDonHangTam),
                    new SQLiteParameter("@NgayDatHang",dhtDTO.NgayDatHang.Date),
                    new SQLiteParameter("@TenNguoiBan",dhtDTO.TenNguoiBan),
                    new SQLiteParameter("@LienHeNguoiBan",dhtDTO.LienHeNguoiBan),
                    new SQLiteParameter("@SDTNguoiBan",dhtDTO.SDTNguoiBan),
                    new SQLiteParameter("@DiaDiemNhanHang",dhtDTO.DiaDiemNhan),
                    new SQLiteParameter("@TenNguoiMua",dhtDTO.TenNguoiMua),
                    new SQLiteParameter("@SDTNguoiMua",dhtDTO.SDTNguoiMua),
                    new SQLiteParameter("@DiaDiemGiaoHang",dhtDTO.DiaDiemGiao),
                    new SQLiteParameter("@TienThuHo",dhtDTO.TienThuHo),
                    new SQLiteParameter("@GhiChu",dhtDTO.GhiChu),
                };
                var n = DataAccessHelper.ExecuteNonQuery
                    (
                    "INSERT INTO DONHANGTAM VALUES(@MaDonHangTam,@NgayDatHang,@TenNguoiBan,@LienHeNguoiBan,@SDTNguoiBan,@DiaDiemNhanHang, @TenNguoiMua,@SDTNguoiMua,@DiaDiemGiaoHang,@TienThuHo,@GhiChu)",
                    parameters
                    );
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

        public static bool XoaDonHangTam(string maDonHangTam)
        {
            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHangTam",maDonHangTam)
                };
                var n = DataAccessHelper.ExecuteNonQuery(
                    "DELETE FROM DONHANGTAM  WHERE MaDonHangTam=@MaDonHangTam", parameters);
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

        public static bool SuaDonHangTam(DTO.DonHangTamDTO dhtDTO)
        {
            bool result = false;


            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    
                    new SQLiteParameter("@MaDonHangTam",dhtDTO.MaDonHangTam),
                    new SQLiteParameter("@NgayDatHang",dhtDTO.NgayDatHang.Date),
                    new SQLiteParameter("@TenNguoiBan",dhtDTO.TenNguoiBan),
                    new SQLiteParameter("@LienHeNguoiBan",dhtDTO.LienHeNguoiBan),
                    new SQLiteParameter("@SDTNguoiBan",dhtDTO.SDTNguoiBan),
                    new SQLiteParameter("@DiaDiemNhanHang",dhtDTO.DiaDiemNhan),
                    new SQLiteParameter("@TenNguoiMua",dhtDTO.TenNguoiMua),
                    new SQLiteParameter("@SDTNguoiMua",dhtDTO.SDTNguoiMua),
                    new SQLiteParameter("@DiaDiemGiaoHang",dhtDTO.DiaDiemGiao),
                    new SQLiteParameter("@TienThuHo",dhtDTO.TienThuHo),
                    new SQLiteParameter("@GhiChu",dhtDTO.GhiChu),
                };
                var n = DataAccessHelper.ExecuteNonQuery(
                    "UPDATE DONHANGTAM SET " +
                    "NgayDatHang=@NgayDatHang," +
                    "TenNguoiBan=@TenNguoiBan," +
                    "LienHeNguoiBan=@LienHeNguoiBan," +
                    "SDTNguoiBan=@SDTNguoiBan" +
                    "DiaDiemNhanHang=@DiaDiemNhanHang," +
                    "TenNguoiMua=@TenNguoiMua," +
                    "SDTNguoiMua=@SDTNguoiMua," +
                    "DiaDiemGiaoHang=@DiaDiemGiaoHang," +
                    "TienThuHo=@TienThuHo," +
                    "GhiChu=@GhiChu " +
                    "WHERE MaDonHangTam=@MaDonHangTam",
                    parameters
                    );
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

        public static List<DonHangTamDTO> SelectDonHangTamAll()
        {
            var list = new List<DonHangTamDTO>();
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("SELECT * FROM DONHANGTAM ");
                list.AddRange(from DataRow dr in dt.Rows
                              select new DonHangTamDTO
                              {
                                  MaDonHangTam = dr["MaDonHangTam"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan=dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  GhiChu = dr["GhiChu"].ToString(),
                              }
                              );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static DTO.DonHangTamDTO SelectDonHangTamByMaDonHangTam(string strMaDonHangTam)
        {
            DTO.DonHangTamDTO dhtDTO = new DTO.DonHangTamDTO();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHangTam",strMaDonHangTam)
                };
                var dt = DataAccessHelper.ExecuteQuery
                    (
                    "SELECT NgayDatHang,TenNguoiBan,LienHeNguoiBan,SDTNguoiBan,DiaDiemNhanHang," +
                                "TenNguoiMua,SDTNguoiMua,DiaDiemGiaoHang,TienThuHo,GhiChu" +
                                " FROM DONHANGTAM WHERE MaDonHangTam=@MaDonHangTam"
                    , parameters
                    );
                var dr = dt.Rows[0];
                dhtDTO.MaDonHangTam = dr["MaDonHangTam"].ToString();
                dhtDTO.NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString());
                dhtDTO.TenNguoiBan = dr["TenNguoiBan"].ToString();
                dhtDTO.LienHeNguoiBan = dr["LienHeNguoiBan"].ToString();
                dhtDTO.SDTNguoiBan = dr["SDTNguoiBan"].ToString();
                dhtDTO.DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString();
                dhtDTO.TenNguoiMua = dr["TenNguoiMua"].ToString();
                dhtDTO.SDTNguoiMua = dr["SDTNguoiMua"].ToString();
                dhtDTO.DiaDiemNhan = dr["DiaDiemNhanHang"].ToString();
                dhtDTO.TienThuHo = double.Parse(dr["TienThuHo"].ToString());
                dhtDTO.GhiChu = dr["GhiChu"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dhtDTO;
        }

        public static bool CheckDonHangTamByMaDonHangTam(string strMaDonHangTam)
        {
            bool result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHangTam",strMaDonHangTam)
                };
                var dt = DataAccessHelper.ExecuteQuery
                   (
                   "SELECT MaDonHangTam FROM DONHANGTAM WHERE MaDonHangTam=@MaDonHangTam"
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

        public static int GenerateNewMaDonHangTam()
        {
            var newMaDonHangTam = 0;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    "Select MAX(CAST(REPLACE(MaDonHangTam , 'DHT', '') as int)) + 1 as NewMaDonHangTam from DonHangTam");
                newMaDonHangTam = dt.Rows[0]["NewMaDonHangTam"].ToString() == "" ?
                    1 :
                    int.Parse(dt.Rows[0]["NewMaDonHangTam"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return newMaDonHangTam;
        }

    }
}
