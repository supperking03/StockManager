using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BUS
{
    public static class DonHangTamBUS
    {
        public static bool ThemDonHangTam(DTO.DonHangTamDTO dhtDTO)
        {
            if (DonHangTamDAL.CheckDonHangTamByMaDonHangTam(dhtDTO.MaDonHangTam))
            {
                throw new Exception("Mã đơn hàng tạm thời đã tồn tại");
            }
            return (DonHangTamDAL.ThemDonHangTam(dhtDTO));
        }


        public static bool XoaDonHangTam(string maDonHangTam)
        {
            if (!DonHangTamDAL.CheckDonHangTamByMaDonHangTam(maDonHangTam))
            {
                throw new Exception("Mã đơn hàng tạm thời không tồn tại");
            }
            return (DonHangTamDAL.XoaDonHangTam(maDonHangTam));
        }

        public static bool SuaDonHangTam(DTO.DonHangTamDTO dhtDTO)
        {
            if (!DonHangTamDAL.CheckDonHangTamByMaDonHangTam(dhtDTO.MaDonHangTam))
            {
                throw new Exception("Mã đơn hàng tạm thời không tồn tại");
            }
            return (DonHangTamDAL.SuaDonHangTam(dhtDTO));
        }

        public static List<DTO.DonHangTamDTO> SelectDonHangTamAll()
        {
            return DonHangTamDAL.SelectDonHangTamAll();
        }

        public static DTO.DonHangTamDTO SelectDonHangTamByMaDonHangTam(string strMaDonHangTam)
        {
            if (!DonHangTamDAL.CheckDonHangTamByMaDonHangTam(strMaDonHangTam))
            {
                return null;
            }
            else
            {
                return DonHangTamDAL.SelectDonHangTamByMaDonHangTam(strMaDonHangTam);
            }
        }

        public static bool CheckDonHangTam(string strMaDonHangTam)
        {
            return DonHangTamDAL.CheckDonHangTamByMaDonHangTam(strMaDonHangTam);
        }

        public static int GenerateNewMaDonHangTam()
        {
            return DonHangTamDAL.GenerateNewMaDonHangTam();
        }
    }
}
