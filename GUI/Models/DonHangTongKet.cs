using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

using DTO;

namespace GUI.Models
{
    class DonHangTongKet: PropertyChangedBase
    {
        private string _tenNguoiBan;
        private string _lienHeNguoiBan;
        private string _sdtNguoiBan;
        private double _tienThuHo;
        private double _tongTien;

        public DonHangTongKet ( )
        {
            
        }

        public DonHangTongKet ( DonHangDTO donHang )
        {
            _tenNguoiBan = donHang.TenNguoiBan;
            _lienHeNguoiBan = donHang.LienHeNguoiBan;
            _sdtNguoiBan = donHang.SDTNguoiBan;
            _tienThuHo = donHang.TienThuHo;
            _tongTien = donHang.TongThanhTien;
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
                NotifyOfPropertyChange ( ()=>TenNguoiBan );
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

        public double TongTien
        {
            get
            {
                return _tongTien;
            }
            set
            {
                _tongTien = value;
                NotifyOfPropertyChange(() => TongTien);
            }
        }
    }
}
