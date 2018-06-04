using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BUS
{
    public class NhanVienBUS
    {
        public static bool ThemNhanVien(DTO.NhanVienDTO nvDTO)
        {
            if (string.IsNullOrEmpty(nvDTO.MaNhanVien))
            {
                throw new Exception($"Nhân viên {nvDTO.MaNhanVien}: Mã nhân viên rỗng");
            }
            if (string.IsNullOrEmpty ( nvDTO.TenNhanVien ))
            {
                throw new Exception($"Nhân viên {nvDTO.MaNhanVien}: Tên nhân viên rỗng");
            }
            if (NhanVienDAL.CheckNhanVienByMaNhanVien(nvDTO.MaNhanVien))
            {
                throw new Exception($"Nhân viên {nvDTO.MaNhanVien}: Mã nhân viên đã tồn tại");
            }
            return (NhanVienDAL.ThemNhanVien(nvDTO));
        }


        public static bool XoaNhanVien(DTO.NhanVienDTO nvDTO)
        {
            if (!NhanVienDAL.CheckNhanVienByMaNhanVien(nvDTO.MaNhanVien))
            {
                throw new Exception("Mã nhân viên không tồn tại");
            }
            return (NhanVienDAL.XoaNhanVien(nvDTO));
        }

        public static bool XoaMoiNhanVien()
        {
            return (NhanVienDAL.XoaMoiNhanVien());
        }


        public static bool SuaNhanVien(DTO.NhanVienDTO nvDTO)
        {
            if (!NhanVienDAL.CheckNhanVienByMaNhanVien(nvDTO.MaNhanVien))
            {
                throw new Exception("Mã nhân viên không tồn tại");
            }
            return (NhanVienDAL.SuaNhanVien(nvDTO));
        }

        public static  List<DTO.NhanVienDTO> SelectNhanVienAll()
        {
            return NhanVienDAL.SelectNhanVienAll();
        }

        public static DTO.NhanVienDTO SelectNhanVienByMaNhanVien(string strMaNhanVien)
        {
            if (!NhanVienDAL.CheckNhanVienByMaNhanVien(strMaNhanVien))
            {
                return null;
            }
            else
                return NhanVienDAL.SelectNhanVienByMaNhanVien(strMaNhanVien);
        }

        public static int GenerateNewMaNhanVien()
        {
            return NhanVienDAL.GenerateNewMaNhanVien();
        }
    }
}
