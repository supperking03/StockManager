using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BUS;

using Caliburn.Micro;

using DTO;

using GUI.Enums;
using GUI.Models;

namespace GUI.ViewModels
{
    [Export(typeof(NhanHangViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    class TongKetViewModel  :PropertyChangedBase
    {
        private NgayThangNam _selectedNgayThangNam;

        private DateTime _selectedNgay;
        private DateTime _selectedThang;
        private DateTime _selectedNam;

        private ObservableCollection < DonHangTongKet > _listDonHangDaGiao;
        private ObservableCollection < DonHangTongKet > _listDonHangDaHuy;

        public TongKetViewModel ( )
        {
            ListDonHangDaGiao = new ObservableCollection<DonHangTongKet>();
            ListDonHangDaHuy = new ObservableCollection<DonHangTongKet>();
            SelectedNgay = DateTime.Now;
            SelectedThang = DateTime.Now;
            SelectedNam = DateTime.Now;
        }

        public NgayThangNam SelectedNgayThangNam
        {
            get
            {
                return _selectedNgayThangNam;
            }
            set
            {
                _selectedNgayThangNam = value;
                switch ( SelectedNgayThangNam )
                {
                    case NgayThangNam.Ngay:
                        ListDonHangDaGiao.Clear (  );
                        ListDonHangDaHuy.Clear (  );

                        foreach ( var donHang in DonHangBUS.SelectDonHangByNgayThangNam ( SelectedNgay.Day,
                            SelectedNgay.Month,
                            SelectedNgay.Year ) )
                        {
                            if ( donHang.TrangThai == TrangThai.DaGiaoHang.ToString ( ) )
                            {
                                ListDonHangDaGiao.Add ( new DonHangTongKet ( donHang ) );
                            }
                            if (donHang.TrangThai == TrangThai.DaHuy.ToString())
                            {
                                ListDonHangDaHuy.Add(new DonHangTongKet(donHang));
                            }
                        }

                        break;
                    case NgayThangNam.Thang:
                        ListDonHangDaGiao.Clear();
                        ListDonHangDaHuy.Clear();

                        foreach (var donHang in DonHangBUS.SelectDonHangByThangNam(SelectedThang.Month,
                            SelectedNgay.Year))
                        {
                            if (donHang.TrangThai == TrangThai.DaGiaoHang.ToString())
                            {
                                ListDonHangDaGiao.Add(new DonHangTongKet(donHang));
                            }
                            if (donHang.TrangThai == TrangThai.DaHuy.ToString())
                            {
                                ListDonHangDaHuy.Add(new DonHangTongKet(donHang));
                            }
                        }

                        break;
                    case NgayThangNam.Nam:
                        ListDonHangDaGiao.Clear();
                        ListDonHangDaHuy.Clear();

                        foreach (var donHang in DonHangBUS.SelectDonHangByNam(SelectedNam.Year))
                        {
                            if (donHang.TrangThai == TrangThai.DaGiaoHang.ToString())
                            {
                                ListDonHangDaGiao.Add(new DonHangTongKet(donHang));
                            }
                            if (donHang.TrangThai == TrangThai.DaHuy.ToString())
                            {
                                ListDonHangDaHuy.Add(new DonHangTongKet(donHang));
                            }
                        }

                        break;
                }
                NotifyOfPropertyChange ( ( ) => SelectedNgayThangNam );
            }
        }

        public DateTime SelectedNgay
        {
            get
            {
                return _selectedNgay;
            }
            set
            {
                _selectedNgay = value;
                ListDonHangDaGiao.Clear();
                ListDonHangDaHuy.Clear();

                foreach (var donHang in DonHangBUS.SelectDonHangByNgayThangNam(SelectedNgay.Day,
                    SelectedNgay.Month,
                    SelectedNgay.Year))
                {
                    if (donHang.TrangThai == TrangThai.DaGiaoHang.ToString())
                    {
                        ListDonHangDaGiao.Add(new DonHangTongKet(donHang));
                    }
                    if (donHang.TrangThai == TrangThai.DaHuy.ToString())
                    {
                        ListDonHangDaHuy.Add(new DonHangTongKet(donHang));
                    }
                }
                NotifyOfPropertyChange(() => SelectedNgay);
            }
        }

        public DateTime SelectedThang
        {
            get
            {
                return _selectedThang;
            }
            set
            {
                _selectedThang = value;
                ListDonHangDaGiao.Clear();
                ListDonHangDaHuy.Clear();

                foreach (var donHang in DonHangBUS.SelectDonHangByThangNam(SelectedThang.Month,
                    SelectedThang.Year))
                {
                    if (donHang.TrangThai == TrangThai.DaGiaoHang.ToString())
                    {
                        ListDonHangDaGiao.Add(new DonHangTongKet(donHang));
                    }
                    if (donHang.TrangThai == TrangThai.DaHuy.ToString())
                    {
                        ListDonHangDaHuy.Add(new DonHangTongKet(donHang));
                    }
                }
                NotifyOfPropertyChange(() => SelectedThang);
            }
        }

        public DateTime SelectedNam
        {
            get
            {
                return _selectedNam;
            }
            set
            {
                _selectedNam = value;
                ListDonHangDaGiao.Clear();
                ListDonHangDaHuy.Clear();

                foreach (var donHang in DonHangBUS.SelectDonHangByNam(SelectedNam.Year))
                {
                    if (donHang.TrangThai == TrangThai.DaGiaoHang.ToString())
                    {
                        ListDonHangDaGiao.Add(new DonHangTongKet(donHang));
                    }
                    if (donHang.TrangThai == TrangThai.DaHuy.ToString())
                    {
                        ListDonHangDaHuy.Add(new DonHangTongKet(donHang));
                    }
                }
                NotifyOfPropertyChange(() => SelectedNam);
            }
        }

        public ObservableCollection < DonHangTongKet > ListDonHangDaGiao
        {
            get
            {
                return _listDonHangDaGiao;
            }
            set
            {
                _listDonHangDaGiao = value;
                NotifyOfPropertyChange ( ( ) => ListDonHangDaGiao );
            }
        }

        public ObservableCollection<DonHangTongKet> ListDonHangDaHuy
        {
            get
            {
                return _listDonHangDaHuy;
            }
            set
            {
                _listDonHangDaHuy = value;
                NotifyOfPropertyChange(() => ListDonHangDaHuy);
            }
        }
    }
}
