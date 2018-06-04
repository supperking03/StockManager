using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public static class DonHangDAL
    {
        public static bool ThemDonHang(DTO.DonHangDTO dhDTO)
        {

            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHang",dhDTO.MaDonHang),
                    new SQLiteParameter("@LoaiDonHang",dhDTO.LoaiDonHang),
                    new SQLiteParameter("@KhuVuc",dhDTO.KhuVuc),
                    new SQLiteParameter("@NgayDatHang",dhDTO.NgayDatHang.Date),
                    new SQLiteParameter("@NgayNhanHang",dhDTO.NgayNhanHang.Date),
                    new SQLiteParameter("@NgayGiaoHang",dhDTO.NgayGiaoHang.Date),
                    new SQLiteParameter("@TrangThai",dhDTO.TrangThai),
                    new SQLiteParameter("@MaNhanVienNhan",dhDTO.MaNhanVienNhan),
                    new SQLiteParameter("@MaNhanVienGiao",dhDTO.MaNhanVienGiao),
                    new SQLiteParameter("@TenNguoiBan",dhDTO.TenNguoiBan),
                    new SQLiteParameter("@LienHeNguoiBan",dhDTO.LienHeNguoiBan),
                    new SQLiteParameter("@SDTNguoiBan",dhDTO.SDTNguoiBan),
                    new SQLiteParameter("@DiaDiemNhanHang",dhDTO.DiaDiemNhan),
                    new SQLiteParameter("@TenNguoiMua",dhDTO.TenNguoiMua),
                    new SQLiteParameter("@SDTNguoiMua",dhDTO.SDTNguoiMua),
                    new SQLiteParameter("@DiaDiemGiaoHang",dhDTO.DiaDiemGiao),
                    new SQLiteParameter("@TienThuHo",dhDTO.TienThuHo),
                    new SQLiteParameter("@PhiVanChuyen",dhDTO.PhiVanChuyen),
                    new SQLiteParameter("@PhiPhatSinh",dhDTO.PhiPhatSinh),
                    new SQLiteParameter("@TongThanhTien",dhDTO.TongThanhTien),
                    new SQLiteParameter("@GhiChu",dhDTO.GhiChu),
                };
                var n = DataAccessHelper.ExecuteNonQuery
                ( "Insert into DONHANG values(@MaDonHang, @LoaiDonHang, @KhuVuc, @NgayDatHang, @NgayNhanHang, @NgayGiaoHang, @TrangThai, @MaNhanVienNhan, @MaNhanVienGiao, @TenNguoiBan, @LienHeNguoiBan, @SDTNguoiBan, @DiaDiemNhanHang, @TenNguoiMua, @SDTNguoiMua, @DiaDiemGiaoHang, @TienThuHo, @PhiVanChuyen, @PhiPhatSinh, @TongThanhTien, @GhiChu)",
                    parameters );
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

        public static bool XoaDonHang(string maDonHang)
        {
            var result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHang",maDonHang)
                };
                var n = DataAccessHelper.ExecuteNonQuery ( "DELETE FROM DONHANG  WHERE MaDonHang=@MaDonHang",
                    parameters );
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

        public static bool SuaDonHang(DTO.DonHangDTO dhDTO)
        {
            bool result = false;


            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHang",dhDTO.MaDonHang),
                    new SQLiteParameter("@LoaiDonHang",dhDTO.LoaiDonHang),
                    new SQLiteParameter("@KhuVuc",dhDTO.KhuVuc),
                    new SQLiteParameter("@NgayDatHang",dhDTO.NgayDatHang.Date),
                    new SQLiteParameter("@NgayNhanHang",dhDTO.NgayNhanHang.Date),
                    new SQLiteParameter("@NgayGiaoHang",dhDTO.NgayGiaoHang.Date),
                    new SQLiteParameter("@TrangThai",dhDTO.TrangThai),
                    new SQLiteParameter("@MaNhanVienNhan",dhDTO.MaNhanVienNhan),
                    new SQLiteParameter("@MaNhanVienGiao",dhDTO.MaNhanVienGiao),
                    new SQLiteParameter("@TenNguoiBan",dhDTO.TenNguoiBan),
                    new SQLiteParameter("@SDTNguoiBan",dhDTO.SDTNguoiBan),
                    new SQLiteParameter("@LienHeNguoiBan",dhDTO.LienHeNguoiBan),
                    new SQLiteParameter("@DiaDiemNhanHang",dhDTO.DiaDiemNhan),
                    new SQLiteParameter("@TenNguoiMua",dhDTO.TenNguoiMua),
                    new SQLiteParameter("@SDTNguoiMua",dhDTO.SDTNguoiMua),
                    new SQLiteParameter("@DiaDiemGiaoHang",dhDTO.DiaDiemGiao),
                    new SQLiteParameter("@TienThuHo",dhDTO.TienThuHo),
                    new SQLiteParameter("@PhiVanChuyen",dhDTO.PhiVanChuyen),
                    new SQLiteParameter("@PhiPhatSinh",dhDTO.PhiPhatSinh),
                    new SQLiteParameter("@TongThanhTien",dhDTO.TongThanhTien),
                    new SQLiteParameter("@GhiChu",dhDTO.GhiChu),
                };
                var n = DataAccessHelper.ExecuteNonQuery(
                    "UPDATE DONHANG SET LoaiDonHang=@LoaiDonHang, KhuVuc=@KhuVuc, NgayDatHang=@NgayDatHang, NgayNhanHang=@NgayNhanHang, NgayGiaoHang=@NgayGiaoHang, TrangThai=@TrangThai, MaNhanVienNhan=@MaNhanVienNhan, MaNhanVienGiao=@MaNhanVienGiao, TenNguoiBan=@TenNguoiBan, LienHeNguoiBan=@LienHeNguoiBan, SDTNguoiBan=@SDTNguoiBan, DiaDiemNhanHang=@DiaDiemNhanHang, TenNguoiMua=@TenNguoiMua, SDTNguoiMua=@SDTNguoiMua, DiaDiemGiaoHang=@DiaDiemGiaoHang, TienThuHo=@TienThuHo, PhiVanChuyen=@PhiVanChuyen, PhiPhatSinh=@PhiPhatSinh, TongThanhTien=@TongThanhTien, GhiChu=@GhiChu WHERE MaDonHang=@MaDonHang",
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

        public static List<DTO.DonHangDTO> SelectDonHangAll()
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("SELECT * FROM DonHang ");
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
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

        public static DTO.DonHangDTO SelectDonHangByMaDonHang(string strMaDonHang)
        {
            DTO.DonHangDTO dhDTO = new DTO.DonHangDTO();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHang",strMaDonHang)
                };
                var dt = DataAccessHelper.ExecuteQuery
                    (
                    "SELECT MaDonHang  FROM DONHANG WHERE MaDonHang=@MaDonHang"
                    , parameters
                    );
                var dr = dt.Rows[0];
                dhDTO.MaDonHang = dr["MaDonHang"].ToString();
                dhDTO.LoaiDonHang = dr["LoaiDonHang"].ToString();
                dhDTO.KhuVuc = dr["KhuVuc"].ToString();
                dhDTO.NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString());
                dhDTO.NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString());
                dhDTO.NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString());
                dhDTO.MaNhanVienNhan = dr["MaNhanVienNhan"].ToString();
                dhDTO.MaNhanVienGiao = dr["MaNhanVienGiao"].ToString();
                dhDTO.TrangThai = dr["TrangThai"].ToString();
                dhDTO.TenNguoiBan = dr["TenNguoiBan"].ToString();
                dhDTO.LienHeNguoiBan = dr["LienHeNguoiBan"].ToString();
                dhDTO.SDTNguoiBan = dr["SDTNguoiBan"].ToString();
                dhDTO.DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString();
                dhDTO.TenNguoiMua = dr["TenNguoiMua"].ToString();
                dhDTO.SDTNguoiMua = dr["SDTNguoiMua"].ToString();
                dhDTO.DiaDiemNhan = dr["DiaDiemNhanHang"].ToString();
                dhDTO.TienThuHo = double.Parse(dr["TienThuHo"].ToString());
                dhDTO.PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString());
                dhDTO.PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString());
                dhDTO.TongThanhTien = double.Parse(dr["TongThanhTien"].ToString());
                dhDTO.GhiChu = dr["GhiChu"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dhDTO;
        }


        public static List<DTO.DonHangDTO> SelectDonHangByKhuVuc(string strKhuVuc)
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@KhuVuc",strKhuVuc)
                };
                var dt = DataAccessHelper.ExecuteQuery("SELECT * FROM DonHang WHERE KHUVUC=@KhuVuc");
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
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

        public static List<DTO.DonHangDTO> SelectDonHangByMaNhanVienNhan(string strMaNhanVienNhan)
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVienNhn",strMaNhanVienNhan)
                };
                var dt = DataAccessHelper.ExecuteQuery("SELECT * FROM DonHang WHERE MANHANVIENNHAN=@MaNhanVienNhan");
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
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

        public static List<DTO.DonHangDTO> SelectDonHangByMaNhanVienGiao(string strMaNhanVienGiao)
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVienGiao",strMaNhanVienGiao)
                };
                var dt = DataAccessHelper.ExecuteQuery("SELECT * FROM DonHang WHERE MaNhanVienGiao=@MaNhanVienGiao");
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
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

        public static List<DTO.DonHangDTO> SelectDonHangByNgayThangNam(int ngay,int thang, int nam)
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@Ngay", ngay),
                    new SQLiteParameter ("@Thang",thang),
                    new SQLiteParameter ("@Nam",nam),
                };
                var dt = DataAccessHelper.ExecuteQuery(@"Select * from DONHANG WHERE cast(strftime('%Y', NgayGiaoHang) as int) = @Nam and
                                                                                     cast(strftime('%m', NgayGiaoHang) as int) = @Thang and
                                                                                     cast(strftime('%d', NgayGiaoHang) as int) = @Ngay ",
                                                       parameters                         
                                                       );
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
                                  GhiChu = dr["GhiChu"].ToString(),
                              });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static List<DTO.DonHangDTO> SelectDonHangByThangNam(int thang, int nam)
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter ("@Thang",thang),
                    new SQLiteParameter ("@Nam",nam),
                };
                var dt = DataAccessHelper.ExecuteQuery(@"Select * from DONHANG WHERE  cast(strftime('%m', NgayGiaoHang) as int) = @Thang and
                                                                                        cast(strftime('%Y', NgayGiaoHang) as int) = @Nam",
                                                       parameters
                                                       );
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
                                  GhiChu = dr["GhiChu"].ToString(),
                              });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }


        public static List<DTO.DonHangDTO> SelectDonHangByNam(int nam)
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter ("@Nam",nam),
                };
                var dt = DataAccessHelper.ExecuteQuery(@"Select * from DONHANG WHERE  cast(strftime('%Y', NgayGiaoHang) as int) = @Nam",
                                                       parameters
                                                       );
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
                                  GhiChu = dr["GhiChu"].ToString(),
                              });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static List<DTO.DonHangDTO> SelectDonHangByLoaiHang(string strLoaiHang)
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@LoaiHang",strLoaiHang)
                };
                var dt = DataAccessHelper.ExecuteQuery("SELECT * FROM DonHang WHERE LoaiHang=@LoaiHang");
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
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

        public static List<DTO.DonHangDTO> SelectDonHangByTrangThai(string strTrangThai)
        {
            var list = new List<DTO.DonHangDTO>();
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@TrangThai",strTrangThai)
                };
                var dt = DataAccessHelper.ExecuteQuery("SELECT * FROM DonHang WHERE TrangThai=@TrangThai", parameters);
                list.AddRange(from DataRow dr in dt.Rows
                              select new DTO.DonHangDTO
                              {
                                  MaDonHang = dr["MaDonHang"].ToString(),
                                  LoaiDonHang = dr["LoaiDonHang"].ToString(),
                                  KhuVuc = dr["KhuVuc"].ToString(),
                                  NgayDatHang = DateTime.Parse(dr["NgayDatHang"].ToString()),
                                  NgayNhanHang = DateTime.Parse(dr["NgayNhanHang"].ToString()),
                                  NgayGiaoHang = DateTime.Parse(dr["NgayGiaoHang"].ToString()),
                                  MaNhanVienNhan = dr["MaNhanVienNhan"].ToString(),
                                  MaNhanVienGiao = dr["MaNhanVienGiao"].ToString(),
                                  TrangThai = dr["TrangThai"].ToString(),
                                  TenNguoiBan = dr["TenNguoiBan"].ToString(),
                                  LienHeNguoiBan = dr["LienHeNguoiBan"].ToString(),
                                  SDTNguoiBan = dr["SDTNguoiBan"].ToString(),
                                  DiaDiemGiao = dr["DiaDiemGiaoHang"].ToString(),
                                  TenNguoiMua = dr["TenNguoiMua"].ToString(),
                                  SDTNguoiMua = dr["SDTNguoiMua"].ToString(),
                                  DiaDiemNhan = dr["DiaDiemNhanHang"].ToString(),
                                  TienThuHo = double.Parse(dr["TienThuHo"].ToString()),
                                  PhiVanChuyen = double.Parse(dr["PhiVanChuyen"].ToString()),
                                  PhiPhatSinh = double.Parse(dr["PhiPhatSinh"].ToString()),
                                  TongThanhTien = double.Parse(dr["TongThanhTien"].ToString()),
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


        public static bool CheckDonHangByMaDonHang(string strMaDonHang)
        {
            bool result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaDonHang",strMaDonHang)
                };
                var dt = DataAccessHelper.ExecuteQuery
                     (
                     "SELECT MaDonHang FROM DONHANG WHERE MaDonHang=@MaDonHang"
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

        public static bool CheckDonHangByMaNhanVienNhan(string strMaNhanVienNhan)
        {
            bool result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVienNhan",strMaNhanVienNhan)
                };
                var dt = DataAccessHelper.ExecuteQuery
                     (
                     "SELECT MaNhanVien FROM NHANVIEN WHERE MaNhanVien=@MaNhanVienNhan"
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


        public static bool CheckDonHangByMaNhanVienGiao(string strMaNhanVienGiao)
        {
            bool result = false;
            try
            {
                var parameters = new List<SQLiteParameter>
                {
                    new SQLiteParameter("@MaNhanVienGiao",strMaNhanVienGiao)
                };
                var dt = DataAccessHelper.ExecuteQuery
                     (
                     "SELECT MaNhanVien FROM NHANVIEN WHERE MaNhanVien=@MaNhanVienGiao"
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

        public static int GenerateNewMaDonHang()
        {
            var newMaDonHang = 0;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    "Select MAX(CAST(REPLACE(MaDonHang , 'DH', '') as int)) + 1 as NewMaDonHang from DonHang");
                newMaDonHang = dt.Rows[0]["NewMaDonHang"].ToString() == "" ?
                    1 :
                    int.Parse(dt.Rows[0]["NewMaDonHang"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return newMaDonHang;
        }
    }
}
