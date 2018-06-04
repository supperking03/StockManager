using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DonHangDTO
    {
        #region declaration property

        private string _strMaDonHang;
        private string _strLoaiDonHang;
        private string _strKhuVuc;
        private DateTime _dtNgayDatHang;
        private DateTime _dtNgayNhanHang;
        private DateTime _dtNgayGiaoHang;
        private string _strTrangThai;
        private string _strMaNhanVienNhan;
        private string _strMaNhanVienGiao;
        private string _strTenNguoiBan;
        private string _strLienHeNguoiBan;
        private string _strSDTNguoiBan;
        private string _strDiaDiemNhanHang;
        private string _strTenNguoiMua;
        private string _strSDTNguoiMua;
        private string _strDiaDiemGiaoHang;
        private double _doubleTienThuHo;
        private double _doublePhiVanChuyen;
        private double _doublePhiPhatSinh;
        private double _doubleTongThanhTien;
        private string _strGhiChu;
        #endregion

        public string MaDonHang
        {
            get
            {
                return _strMaDonHang;
            }
            set
            {
                _strMaDonHang = value;
            }
        }

        public string LoaiDonHang
        {
            get
            {
                return _strLoaiDonHang;
            }
            set
            {
                _strLoaiDonHang = value;
            }
        }

        public string KhuVuc
        {
            get
            {
                return _strKhuVuc;
            }
            set
            {
                _strKhuVuc = value;
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

        public DateTime NgayNhanHang
        {
            get
            {
                return _dtNgayNhanHang;
            }
            set
            {
                _dtNgayNhanHang = value;
            }
        }

        public DateTime NgayGiaoHang
        {
            get
            {
                return _dtNgayGiaoHang;
            }
            set
            {
                _dtNgayGiaoHang = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return _strTrangThai;
            }
            set
            {
                _strTrangThai = value;
            }
        }

        public string MaNhanVienNhan
        {
            get
            {
                return _strMaNhanVienNhan;
            }
            set
            {
                _strMaNhanVienNhan = value;
            }
        }


        public string MaNhanVienGiao
        {
            get
            {
                return _strMaNhanVienGiao;
            }
            set
            {
                _strMaNhanVienGiao = value;
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
                return _strDiaDiemNhanHang;
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

        public double PhiVanChuyen
        {
            get
            {
                return _doublePhiVanChuyen;
            }
            set
            {
                _doublePhiVanChuyen = value;
            }
        }

        public double PhiPhatSinh
        {
            get
            {
                return _doublePhiPhatSinh;
            }
            set
            {
                _doublePhiPhatSinh = value;
            }

        }

        public double TongThanhTien
        {
            get
            {
                return _doubleTongThanhTien;
            }
            set
            {
                _doubleTongThanhTien = value;
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

        public DonHangDTO()
        {
            _strMaDonHang = "";
            _strLoaiDonHang = "";
            _strKhuVuc = "";
            _dtNgayDatHang = DateTime.MinValue;
            _dtNgayNhanHang = DateTime.MinValue;
            _dtNgayGiaoHang = DateTime.MinValue;
            _strTrangThai="";
            _strMaNhanVienNhan="";
            _strMaNhanVienGiao="";
            _strTenNguoiBan="";
            _strLienHeNguoiBan="";
            _strSDTNguoiMua="";
            _strDiaDiemNhanHang="";
            _strTenNguoiMua="";
            _strDiaDiemGiaoHang="";
            _doubleTienThuHo=0;
            _doublePhiVanChuyen=0;
            _doublePhiPhatSinh = 0;
            _doubleTongThanhTien=0;
            _strGhiChu="";
            _strSDTNguoiBan = "";
        }

        public DonHangDTO
            (
            string MaDonHang,
            string LoaiDonHang,
            string KhuVuc,
            DateTime NgayDatHang,
            DateTime NgayNhanHang,
            DateTime NgayGiaoHang,
            string TrangThai,
            string MaNhanVienNhan,
            string MaNhanVienGiao,
            string TenNguoiBan,
            string LienHeNguoiBan,
            string SDTNguoiBan,
            string DiaDiemNhan,
            string TenNguoiMua,
            string SDTNguoiMua,
            string DiaDiemGiao,
            double TienThuHo,
            double PhiVanChuyen,
            double PhiPhatSinh,
            double TongThanhTien,
            string GhiChu
            )
        {
            _strMaDonHang = MaDonHang;
            _strLoaiDonHang = LoaiDonHang; 
            _strKhuVuc = KhuVuc;
            _dtNgayDatHang = NgayDatHang;
            _dtNgayGiaoHang = NgayGiaoHang;
            _dtNgayNhanHang = NgayNhanHang;
            _strTrangThai = TrangThai;
            _strMaNhanVienGiao = MaNhanVienGiao;
            _strMaNhanVienNhan = MaNhanVienNhan;
            _strTenNguoiBan = TenNguoiBan;
            _strTenNguoiMua = TenNguoiMua;
            _strLienHeNguoiBan = LienHeNguoiBan;
            _strSDTNguoiMua = SDTNguoiMua;
            _strDiaDiemGiaoHang = DiaDiemGiao;
            _strDiaDiemNhanHang = DiaDiemNhan;
            _doubleTienThuHo = TienThuHo;
            _doublePhiVanChuyen = PhiVanChuyen;
            _doublePhiPhatSinh = PhiPhatSinh;
            _doubleTongThanhTien = TongThanhTien;
            _strGhiChu = GhiChu;
        }

        public DonHangDTO(DonHangDTO donhang)
        {
            _strMaDonHang = donhang.MaDonHang;
            _strLoaiDonHang = donhang.LoaiDonHang;
            _strKhuVuc = donhang.KhuVuc;
            _dtNgayDatHang = donhang.NgayDatHang;
            _dtNgayGiaoHang = donhang.NgayGiaoHang;
            _dtNgayNhanHang = donhang.NgayNhanHang;
            _strTrangThai = donhang.TrangThai;
            _strMaNhanVienGiao = donhang.MaNhanVienGiao;
            _strMaNhanVienNhan = donhang.MaNhanVienNhan;
            _strTenNguoiBan = donhang.TenNguoiBan;
            _strTenNguoiMua = donhang.TenNguoiMua;
            _strLienHeNguoiBan = donhang.LienHeNguoiBan;
            _strSDTNguoiMua = donhang.SDTNguoiMua;
            _strDiaDiemGiaoHang = donhang.DiaDiemGiao;
            _strDiaDiemNhanHang = donhang.DiaDiemNhan;
            _doubleTienThuHo = donhang.TienThuHo;
            _doublePhiVanChuyen = donhang.PhiVanChuyen;
            _doublePhiPhatSinh = donhang.PhiPhatSinh;
            _doubleTongThanhTien = donhang.TongThanhTien;
            _strGhiChu = donhang.GhiChu;
        }
    }
}
