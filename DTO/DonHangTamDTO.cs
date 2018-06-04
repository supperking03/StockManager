using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHangTamDTO
    {
        private string _strMaDonHangTam;
        private DateTime _dtNgayDatHang;
        private string _strTenNguoiBan;
        private string _strLienHeNguoiBan;
        private string _strSDTNguoiBan;
        private string _strSDTNguoiMua;
        private string _strDiaDiemNhanHang;
        private string _strTenNguoiMua;
        private string _strDiaDiemGiaoHang;
        private double _doubleTienThuHo;
        private string _strGhiChu;
        
        public string MaDonHangTam
        {
            get
            {
                return _strMaDonHangTam;
            }
            set
            {
                _strMaDonHangTam = value;
            }
        }
        public string SDTNguoiBan
        {
            get
            {
                return _strSDTNguoiBan;
            }
            set
            {
                _strSDTNguoiBan = value;
            }
        }

        public DateTime NgayDatHang
        {
            get
            {
                return _dtNgayDatHang;
            }
            set
            {
                _dtNgayDatHang = value;
            }
        }

        public string TenNguoiBan
        {
            get
            {
                return _strTenNguoiBan;
            }
            set
            {
                _strTenNguoiBan = value;
            }
        }

        public string LienHeNguoiBan
        {
            get
            {
                return _strLienHeNguoiBan;
            }
            set
            {
                _strLienHeNguoiBan = value;
            }
        }

        public string SDTNguoiMua
        {
            get
            {
                return _strSDTNguoiMua;
            }
            set
            {
                _strSDTNguoiMua = value;
            }
        }

        public string DiaDiemNhan
        {
            get
            {
                return _strDiaDiemGiaoHang;
            }
            set
            {
                _strDiaDiemNhanHang = value;
            }
        }

        public string TenNguoiMua
        {
            get
            {
                return _strTenNguoiMua;
            }
            set
            {
                _strTenNguoiMua = value;
            }
        }

        public string DiaDiemGiao
        {
            get
            {
                return _strDiaDiemGiaoHang;
            }
            set
            {
                _strDiaDiemGiaoHang = value;
            }
        }
        public double TienThuHo
        {
            get
            {
                return _doubleTienThuHo;
            }
            set
            {
                _doubleTienThuHo = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return _strGhiChu;
            }
            set
            {
                _strGhiChu = value;
            }
        }

 

        public DonHangTamDTO()
        {
            _strMaDonHangTam = "";
            _dtNgayDatHang = DateTime.MinValue;
            _strTenNguoiBan = "";
            _strLienHeNguoiBan = "";
            _strSDTNguoiMua = "";
            _strSDTNguoiBan = "";
            _strDiaDiemNhanHang = "";
            _strTenNguoiMua = "";
            _strDiaDiemGiaoHang = "";
            _doubleTienThuHo = 0;
            _strGhiChu = "";
  
        }

        public DonHangTamDTO
            (
            string MaDonHangTam,
            DateTime NgayDatHang,
            string TenNguoiBan,
            string LienHeNguoiBan,
            string SDTNguoiBan,
            string DiaDiemNhan,
            string TenNguoiMua,
            string SDTNguoiMua,
            string DiaDiemGiaoHang,
            string GhiChu,
            double TienVanChuyen,
            double TienThuHo
            )
        {
            _strSDTNguoiBan = SDTNguoiBan;
            _strMaDonHangTam = MaDonHangTam;
            _dtNgayDatHang = NgayDatHang;
            _strTenNguoiBan = TenNguoiBan;
            _strLienHeNguoiBan = LienHeNguoiBan;
            _strSDTNguoiMua = SDTNguoiMua;
            _strDiaDiemGiaoHang = DiaDiemGiaoHang;
            _strDiaDiemNhanHang = DiaDiemNhan;
            _strGhiChu = GhiChu;
            _strTenNguoiMua = TenNguoiMua;
            _doubleTienThuHo = TienThuHo;
            
        }

        public DonHangTamDTO(DonHangTamDTO donhangtam)
        {
            _strSDTNguoiBan = donhangtam.SDTNguoiBan;
            _strMaDonHangTam = donhangtam.MaDonHangTam;
            _dtNgayDatHang = donhangtam._dtNgayDatHang;
            _strTenNguoiBan = donhangtam._strTenNguoiBan;
            _strLienHeNguoiBan = donhangtam._strLienHeNguoiBan;
            _strDiaDiemNhanHang = donhangtam._strDiaDiemNhanHang;
            _strTenNguoiMua = donhangtam._strTenNguoiMua;
            _strSDTNguoiMua = donhangtam._strSDTNguoiMua;
            _strDiaDiemGiaoHang = donhangtam._strDiaDiemGiaoHang;
            _doubleTienThuHo = donhangtam._doubleTienThuHo;
            _strGhiChu = donhangtam._strGhiChu;

        }

    }
}
