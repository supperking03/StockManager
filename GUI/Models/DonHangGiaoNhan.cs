using System;
using System.Collections.Generic;

using Caliburn.Micro;

using DTO;

using GUI.Enums;

using BUS;

namespace GUI.Models
{
    public class DonHangGiaoNhan : PropertyChangedBase
    {
        private string _maDonHang;
        private LoaiDonHang _tenLoaiDonHang;
        private KhuVuc _tenKhuVuc;
        private DateTime _ngayDatHang;
        private DateTime _ngayNhanHang;
        private DateTime _ngayGiaoHang;
        private TrangThai _tenTrangThai;
        private string _maNhanVienNhan;
        private string _maNhanVienGiao;
        private string _tenNguoiBan;
        private string _lienHeNguoiBan;
        private string _sdtNguoiBan;
        private string _diaDiemNhanHang;
        private string _tenNguoiMua;
        private string _sdtNguoiMua;
        private string _diaDiemGiaoHang;
        private double _tienThuHo;
        private double _phiVanChuyen;
        private double _phiPhatSinh;
        private double _tongThanhTien;
        private string _ghiChu;
        public DonHangGiaoNhan()
        {
            _ngayDatHang = DateTime.Now;
            _ngayGiaoHang = DateTime.Now;
            _ngayNhanHang = DateTime.Now;

            _tienThuHo = 0;
            _phiVanChuyen = 0;
            _phiPhatSinh = 0;
            _tongThanhTien = 0;
        }

        public DonHangGiaoNhan(DonHangDTO donHang)
        {
            MaDonHang = donHang.MaDonHang;
            TenLoaiDonHang = (LoaiDonHang)Enum.Parse(typeof(LoaiDonHang), donHang.LoaiDonHang);
            TenKhuVuc = (KhuVuc)Enum.Parse(typeof(KhuVuc), donHang.KhuVuc);
            NgayDatHang = donHang.NgayDatHang;
            NgayNhanHang = donHang.NgayNhanHang;
            NgayGiaoHang = donHang.NgayGiaoHang;
            TenTrangThai = (TrangThai)Enum.Parse(typeof(TrangThai), donHang.TrangThai);
            MaNhanVienNhan = donHang.MaNhanVienNhan;
            MaNhanVienGiao = donHang.MaNhanVienGiao;
            TenNguoiBan = donHang.TenNguoiBan;
            LienHeNguoiBan = donHang.LienHeNguoiBan;
            SdtNguoiBan = donHang.SDTNguoiBan;
            DiaDiemNhanHang = donHang.DiaDiemNhan;
            TenNguoiMua = donHang.TenNguoiMua;
            SdtNguoiMua = donHang.SDTNguoiMua;
            DiaDiemGiaoHang = donHang.DiaDiemGiao;
            TienThuHo = donHang.TienThuHo;
            PhiVanChuyen = donHang.PhiVanChuyen;
            PhiPhatSinh = donHang.PhiPhatSinh;
            TongThanhTien = donHang.TongThanhTien;
            GhiChu = donHang.GhiChu;
        }

        public DonHangGiaoNhan(DonHangTamThoi donHang)
        {
            NgayDatHang = donHang.NgayDatHang;
            TenNguoiBan = donHang.TenNguoiBan;
            LienHeNguoiBan = donHang.LienHeNguoiBan;
            SdtNguoiBan = donHang.SdtNguoiBan;
            SdtNguoiMua = donHang.SdtNguoiMua;
            DiaDiemNhanHang = donHang.DiaDiemNhanHang;
            DiaDiemGiaoHang = donHang.DiaDiemGiaoHang;
            TenNguoiMua = donHang.TenNguoiMua;
            TienThuHo = donHang.TienThuHo;
            GhiChu = donHang.GhiChu;
        }

        public string MaDonHang
        {
            get
            {
                return _maDonHang;
            }
            set
            {
                _maDonHang = value;
                NotifyOfPropertyChange(() => MaDonHang);
            }
        }

        public LoaiDonHang TenLoaiDonHang
        {
            get
            {
                return _tenLoaiDonHang;
            }
            set
            {
                _tenLoaiDonHang = value;
                NotifyOfPropertyChange(() => TenLoaiDonHang);
            }
        }

        public KhuVuc TenKhuVuc
        {
            get
            {
                return _tenKhuVuc;
            }
            set
            {
                _tenKhuVuc = value;
                NotifyOfPropertyChange(() => TenKhuVuc);
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
                NotifyOfPropertyChange(() => NgayDatHang);
            }
        }

        public DateTime NgayNhanHang
        {
            get
            {
                return _ngayNhanHang;
            }
            set
            {
                _ngayNhanHang = value;
                NotifyOfPropertyChange(() => NgayNhanHang);
            }
        }

        public DateTime NgayGiaoHang
        {
            get
            {
                return _ngayGiaoHang;
            }
            set
            {
                _ngayGiaoHang = value;
                NotifyOfPropertyChange(() => NgayGiaoHang);
            }
        }

        public TrangThai TenTrangThai
        {
            get
            {
                return _tenTrangThai;
            }
            set
            {
                _tenTrangThai = value;
                NotifyOfPropertyChange(() => TenTrangThai);
            }
        }

        public string MaNhanVienNhan
        {
            get
            {
                return _maNhanVienNhan;
            }
            set
            {
                _maNhanVienNhan = value;
                NotifyOfPropertyChange(() => MaNhanVienNhan);
            }
        }

        public string MaNhanVienGiao
        {
            get
            {
                return _maNhanVienGiao;
            }
            set
            {
                _maNhanVienGiao = value;
                NotifyOfPropertyChange(() => MaNhanVienGiao);
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
                NotifyOfPropertyChange(() => TenNguoiBan);
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
                NotifyOfPropertyChange(() => LienHeNguoiBan);
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
                NotifyOfPropertyChange(() => SdtNguoiMua);
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
                NotifyOfPropertyChange(() => DiaDiemNhanHang);
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
                NotifyOfPropertyChange(() => TenNguoiMua);
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
                NotifyOfPropertyChange(() => DiaDiemGiaoHang);
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
                NotifyOfPropertyChange(() => TienThuHo);
            }
        }

        public double PhiVanChuyen
        {
            get
            {
                return _phiVanChuyen;
            }
            set
            {
                _phiVanChuyen = value;
                NotifyOfPropertyChange(() => PhiVanChuyen);
            }
        }

        public double PhiPhatSinh
        {
            get
            {
                return _phiPhatSinh;
            }
            set
            {
                _phiPhatSinh = value;
                NotifyOfPropertyChange(() => PhiPhatSinh);
            }
        }

        public double TongThanhTien
        {
            get
            {
                return _tongThanhTien;
            }
            set
            {
                _tongThanhTien = value;
                NotifyOfPropertyChange(() => TongThanhTien);
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
                NotifyOfPropertyChange(() => GhiChu);
            }
        }
    }
}
