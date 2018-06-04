using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BUS
{
    public static class DonHangBUS
    {
        public static bool ThemDonHang(DTO.DonHangDTO dhDTO)
        {
            if ( string.IsNullOrEmpty ( dhDTO.TenNguoiBan ) )
            {
                throw  new Exception($"Đơn hàng {dhDTO.MaDonHang}: Tên người bán chưa nhập");
            }

            if (string.IsNullOrEmpty(dhDTO.LienHeNguoiBan))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: Tên người bán chưa nhập");
            }

            if (string.IsNullOrEmpty(dhDTO.SDTNguoiBan))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: SĐT bán chưa nhập");
            }

            if (string.IsNullOrEmpty(dhDTO.DiaDiemNhan))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: Địa điểm nhận hàng chưa nhập");
            }

            if (string.IsNullOrEmpty(dhDTO.TenNguoiMua))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: Tên người mua chưa nhập");
            }

            if (string.IsNullOrEmpty(dhDTO.SDTNguoiMua))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: SĐT người mua chưa nhập");
            }

            if (string.IsNullOrEmpty(dhDTO.DiaDiemGiao))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: Địa điểm giao hàng chưa nhập");
            }

            if (DonHangDAL.CheckDonHangByMaDonHang(dhDTO.MaDonHang))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: Mã đơn hàng đã tồn tại");
            }

            if (!DonHangDAL.CheckDonHangByMaNhanVienNhan(dhDTO.MaNhanVienNhan))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: Mã nhân viên nhận hàng không đã tồn tại");
            }

            if (!DonHangDAL.CheckDonHangByMaNhanVienGiao(dhDTO.MaNhanVienGiao))
            {
                throw new Exception($"Đơn hàng {dhDTO.MaDonHang}: Mã nhân viên giao hàng không tồn tại");
            }

            return (DonHangDAL.ThemDonHang(dhDTO));
        }


        public static bool XoaDonHang(string maDonHang)
        {
            if (!DonHangDAL.CheckDonHangByMaDonHang(maDonHang))
            {
                throw new Exception("Mã đơn hàng không tồn tại");
            }
            return (DonHangDAL.XoaDonHang(maDonHang));
        }


        public static bool SuaDonHang(DTO.DonHangDTO dhDTO)
        {
            if (!DonHangDAL.CheckDonHangByMaDonHang(dhDTO.MaDonHang))
            {
                throw new Exception("Mã đơn hàng không tồn tại");
            }
            return (DonHangDAL.SuaDonHang(dhDTO));
        }

        public static List<DTO.DonHangDTO> SelectDonHangAll()
        {
            return DonHangDAL.SelectDonHangAll();
        }

        public static DTO.DonHangDTO SelectDonHangByMaDonHang(string strMaDonHang)
        {
            if (!DonHangDAL.CheckDonHangByMaDonHang(strMaDonHang))
            {
                return null;
            }
            else
                return DonHangDAL.SelectDonHangByMaDonHang(strMaDonHang);
        }

        public static List<DTO.DonHangDTO> SelectDonHangByKhuVuc(string strKhuVuc)
        {
            return DonHangDAL.SelectDonHangByKhuVuc(strKhuVuc);
        }

        public static List<DTO.DonHangDTO> SelectDonHangByMaNhanVienNhan(string strMaNhanVienNhan)
        {
            if (!DonHangDAL.CheckDonHangByMaNhanVienNhan(strMaNhanVienNhan))
            {
                return null;
            }
            else
                return DonHangDAL.SelectDonHangByMaNhanVienNhan(strMaNhanVienNhan);
        }


        public static List<DTO.DonHangDTO> SelectDonHangByMaNhanVienGiao(string strMaNhanVienGiao)
        {
            if (!DonHangDAL.CheckDonHangByMaNhanVienGiao(strMaNhanVienGiao))
            {
                return null;
            }
            else
            {
                return DonHangDAL.SelectDonHangByMaNhanVienGiao(strMaNhanVienGiao);
            }
        }

        public static List<DTO.DonHangDTO> SelectDonHangByLoaiHang(string strLoaiHang)
        {
            return DonHangDAL.SelectDonHangByLoaiHang(strLoaiHang);
        }

        public static List<DTO.DonHangDTO> SelectDonHangByTrangThai(string strTrangThai)
        {
            return DonHangDAL.SelectDonHangByTrangThai(strTrangThai);
        }

        public static List<DTO.DonHangDTO> SelectDonHangByNgayThangNam(int ngay, int thang, int nam)
        {
            return DonHangDAL.SelectDonHangByNgayThangNam(ngay, thang, nam);
        }

        public static List<DTO.DonHangDTO> SelectDonHangByThangNam(int thang, int nam)
        {
            return DonHangDAL.SelectDonHangByThangNam(thang, nam);
        }

        public static List<DTO.DonHangDTO> SelectDonHangByNam(int nam)
        {
            return DonHangDAL.SelectDonHangByNam(nam);
        }
        public static int GenerateNewMaDonHang()
        {
            return DonHangDAL.GenerateNewMaDonHang();
        }
    }
}
