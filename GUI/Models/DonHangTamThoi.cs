using System;

using Caliburn.Micro;

using DTO;

namespace GUI.Models
{
    public class DonHangTamThoi : PropertyChangedBase
    {
        private string _maDonHangTam;
        private DateTime _ngayDatHang;
        private string _tenNguoiBan;
        private string _lienHeNguoiBan;
        private string _sdtNguoiBan;
        private string _sdtNguoiMua;
        private string _diaDiemNhanHang;
        private string _tenNguoiMua;
        private string _diaDiemGiaoHang;
        private double _tienThuHo;
        private string _ghiChu;

        public DonHangTamThoi ( )
        {
            
        }

        public DonHangTamThoi ( DonHangTamDTO donHang )
        {
            MaDonHangTam = donHang.MaDonHangTam;
            NgayDatHang = donHang.NgayDatHang;
            TenNguoiBan = donHang.TenNguoiBan;
            LienHeNguoiBan = donHang.LienHeNguoiBan;
            SdtNguoiBan = donHang.SDTNguoiBan;
            SdtNguoiMua = donHang.SDTNguoiMua;
            DiaDiemNhanHang = donHang.DiaDiemNhan;
            TenNguoiMua = donHang.TenNguoiMua;
            DiaDiemGiaoHang = donHang.DiaDiemGiao;
            TienThuHo = donHang.TienThuHo;
            GhiChu = donHang.GhiChu;
        }

        public string MaDonHangTam
        {
            get
            {
                return _maDonHangTam;
            }
            set
            {
                _maDonHangTam = value;
                NotifyOfPropertyChange(() => MaDonHangTam);
            }
        }

        public DateTime NgayDatHang
        {
            get
            {
                return _ngayDatHang;
            }
            set
            {
                _ngayDatHang = value;
                NotifyOfPropertyChange ( ( ) => NgayDatHang );
            }
        }

        public string TenNguoiBan
        {
            get
            {
                return _tenNguoiBan;
            }
            set
            {
                _tenNguoiBan = value;
                NotifyOfPropertyChange ( ( ) => TenNguoiBan );
            }
        }

        public string LienHeNguoiBan
        {
            get
            {
                return _lienHeNguoiBan;
            }
            set
            {
                _lienHeNguoiBan = value;
                NotifyOfPropertyChange ( ( ) => LienHeNguoiBan );
            }
        }

        public string SdtNguoiBan
        {
            get
            {
                return _sdtNguoiBan;
            }
            set
            {
                _sdtNguoiBan = value;
                NotifyOfPropertyChange(() => SdtNguoiBan);
            }
        }

        public string SdtNguoiMua
        {
            get
            {
                return _sdtNguoiMua;
            }
            set
            {
                _sdtNguoiMua = value;
                NotifyOfPropertyChange ( ( ) => SdtNguoiMua);
            }
        }

        public string DiaDiemNhanHang
        {
            get
            {
                return _diaDiemNhanHang;
            }
            set
            {
                _diaDiemNhanHang = value;
                NotifyOfPropertyChange ( ( ) => DiaDiemNhanHang );
            }
        }

        public string TenNguoiMua
        {
            get
            {
                return _tenNguoiMua;
            }
            set
            {
                _tenNguoiMua = value;
                NotifyOfPropertyChange ( ( ) => TenNguoiMua );
            }
        }

        public string DiaDiemGiaoHang
        {
            get
            {
                return _diaDiemGiaoHang;
            }
            set
            {
                _diaDiemGiaoHang = value;
                NotifyOfPropertyChange ( ( ) => DiaDiemGiaoHang );
            }
        }

        public double TienThuHo
        {
            get
            {
                return _tienThuHo;
            }
            set
            {
                _tienThuHo = value;
                NotifyOfPropertyChange ( ( ) => TienThuHo );
            }
        }

        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }
            set
            {
                _ghiChu = value;
                NotifyOfPropertyChange ( ( ) => GhiChu );
            }
        }
    }
}
