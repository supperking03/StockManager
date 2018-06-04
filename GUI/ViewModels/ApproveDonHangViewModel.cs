using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.Composition;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;

using Caliburn.Micro;

using GUI.Enums;
using GUI.Models;

using BUS;

using DTO;

namespace GUI.ViewModels
{
    [Export(typeof(ApproveDonHangViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public sealed class ApproveDonHangViewModel : PropertyChangedBase
    {
        private readonly WindowManager _windowManager;

        private ObservableCollection<DonHangTamThoi> _donHangTamThoiList;
        private ObservableCollection < DonHangChinhThuc > _donHangChinhThucList;
        private ObservableCollection < string > _nhanVienList;

        private DonHangTamThoi _selectedDonHangTamThoi;
        private DonHangChinhThuc _selectedDonHangChinhThuc;

        private int _baseMaDonHangChinhThuc;

        public ApproveDonHangViewModel ( )
        {
            _windowManager = new WindowManager (  );

            NhanVienList = new ObservableCollection < string > (NhanVienBUS.SelectNhanVienAll().Select ( x => x.MaNhanVien ).ToList ( ) );

            DonHangTamThoiList = new ObservableCollection<DonHangTamThoi>();
            DonHangChinhThucList = new ObservableCollection<DonHangChinhThuc>();

            RefreshDonHangTamThoi (  );

            _baseMaDonHangChinhThuc = DonHangBUS.GenerateNewMaDonHang ( );

            DonHangChinhThucList.CollectionChanged += ( sender, args ) =>
            {
                if ( args.Action == NotifyCollectionChangedAction.Add )
                {
                    ( ( DonHangChinhThuc ) args.NewItems [ 0 ] ).MaDonHang =
                        $"DH{_baseMaDonHangChinhThuc + DonHangChinhThucList.Count - 1:0000}";
                    ((DonHangChinhThuc)args.NewItems[0]).NgayGiaoHang = DateTime.Now.Date;
                    ((DonHangChinhThuc)args.NewItems[0]).NgayNhanHang = DateTime.Now.Date;
                    ( ( DonHangChinhThuc ) args.NewItems [ 0 ] ).TenTrangThai = TrangThai.DaXacNhan;
                    ((DonHangChinhThuc)args.NewItems[0]).MaNhanVienGiao = NhanVienList[0];
                    ((DonHangChinhThuc)args.NewItems[0]).MaNhanVienNhan = NhanVienList[0];
                }
            };
        }

        public ObservableCollection < DonHangTamThoi > DonHangTamThoiList
        {
            get
            {
                return _donHangTamThoiList;
            }
            set
            {
                _donHangTamThoiList = value;
                NotifyOfPropertyChange(() => DonHangTamThoiList);
            }
        }

        public ObservableCollection < DonHangChinhThuc > DonHangChinhThucList
        {
            get
            {
                return _donHangChinhThucList;
            }
            set
            {
                _donHangChinhThucList = value;
                NotifyOfPropertyChange(() => DonHangChinhThucList);
            }
        }

        public ObservableCollection<string> NhanVienList
        {
            get
            {
                return _nhanVienList;
            }
            set
            {
                _nhanVienList = value;
                NotifyOfPropertyChange(() => NhanVienList);
            }
        }

        public DonHangTamThoi SelectedDonHangTamThoi
        {
            get
            {
                return _selectedDonHangTamThoi;
            }
            set
            {
                _selectedDonHangTamThoi = value;
                NotifyOfPropertyChange(() => SelectedDonHangTamThoi);
            }
        }

        public DonHangChinhThuc SelectedDonHangChinhThuc
        {
            get
            {
                return _selectedDonHangChinhThuc;
            }
            set
            {
                _selectedDonHangChinhThuc = value;
                NotifyOfPropertyChange(() => SelectedDonHangChinhThuc);
            }
        }

        public void ApproveAwaiting ( )
        {
            if ( SelectedDonHangTamThoi == null )
            {
                return;
            }

            var dialog = IoC.Get < DialogViewModel > ( );
            dialog.Question = "Xác nhận đơn hàng đã chọn?";
            dialog.DisplayName = "";
            
            var result = _windowManager.ShowDialog(dialog);

            if ( result != true )
            {
                return;
            }

            try
            {
                DonHangTamBUS.XoaDonHangTam(SelectedDonHangTamThoi.MaDonHangTam);
                DonHangChinhThucList.Add(new DonHangChinhThuc(SelectedDonHangTamThoi));
                DonHangTamThoiList.Remove(SelectedDonHangTamThoi);
            }
            catch ( Exception e )
            {
                var error = IoC.Get<ErrorViewModel>();
                error.ErrorName = e.Message;
                error.DisplayName = "Lỗi";
                _windowManager.ShowDialog(error);
            }

        }

        public void RemoveAwaiting ( )
        {
            if (SelectedDonHangTamThoi == null)
            {
                return;
            }

            var dialog = IoC.Get<DialogViewModel>();
            dialog.Question = "Xóa đơn hàng đã chọn?";
            dialog.DisplayName = "";

            var result = _windowManager.ShowDialog(dialog);

            if (result != true)
            {
                return;
            }

            try
            {
                DonHangTamBUS.XoaDonHangTam(SelectedDonHangTamThoi.MaDonHangTam);
                DonHangTamThoiList.Remove(SelectedDonHangTamThoi);
            }
            catch ( Exception e )
            {
                var error = IoC.Get<ErrorViewModel>();
                error.ErrorName = e.Message;
                error.DisplayName = "Lỗi";
                _windowManager.ShowDialog(error);
            }
        }

        public void RemoveApproved()
        {
            if (SelectedDonHangChinhThuc == null)
            {
                return;
            }

            var dialog = IoC.Get<DialogViewModel>();
            dialog.Question = "Xóa đơn hàng đã chọn?";
            dialog.DisplayName = "";

            var result = _windowManager.ShowDialog(dialog);

            if (result != true)
            {
                return;
            }

            DonHangChinhThucList.Remove(SelectedDonHangChinhThuc);
        }

        public void RefreshDonHangTamThoi ( )
        {
            try
            {
                GetDonHangTamFromServer();
            }
            catch ( System.Net.WebException e )
            {
                var error = IoC.Get<ErrorViewModel>();
                error.ErrorName = "Có vấn đề về mạng";
                error.DisplayName = "Lỗi";
                _windowManager.ShowDialog(error);
            }

            DonHangTamThoiList.Clear (  );
            foreach ( var donHang in DonHangTamBUS.SelectDonHangTamAll (  ) )
            {
                DonHangTamThoiList.Add ( new DonHangTamThoi(donHang) );
            }
        }

        private void GetDonHangTamFromServer ( )
        {
            const string url = "http://kienuit.esy.es/don_hang.php";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var sr = new StreamReader(response.GetResponseStream());
            var result = sr.ReadToEnd();

            var customers = result.Split('-').TakeWhile ( x=>x !="" );

            if ( result == "0 results" )
            {
                return;
            }

            foreach ( var customer in customers )
            {
                var str = customer.Split ( '@' );
                var donHang = new DonHangTamDTO
                {
                    MaDonHangTam = str [ 9 ],
                    NgayDatHang = DateTime.ParseExact ( str [ 10 ], "dd/MM/yyyy HH:mm:ss",
                        CultureInfo.InvariantCulture ),
                    TenNguoiBan = str [ 0 ],
                    LienHeNguoiBan = str [ 2 ],
                    SDTNguoiBan = str [ 1 ],
                    SDTNguoiMua = str [ 8 ],
                    DiaDiemNhan = str [ 6 ],
                    TenNguoiMua = str [ 7 ],
                    DiaDiemGiao = str [ 5 ],
                    TienThuHo = double.Parse ( str [ 4 ] ),
                    GhiChu = str [ 3 ]
                };

                if ( DonHangTamBUS.CheckDonHangTam ( donHang.MaDonHangTam ) )
                {
                    string url2 = $"http://kienuit.esy.es/xoa_hang.php?Ma={donHang.MaDonHangTam}";
                    HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url2);
                    HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
                    continue;
                }

                var mail = new MailMessage("binhdinhexphanmem@gmail.com", "binhdinhexthongbaophanmem@gmail.com",
                    "[Đơn hàng chưa xác nhận]" + donHang.MaDonHangTam,
                    $"{donHang.MaDonHangTam}|{donHang.NgayDatHang}|{donHang.TenNguoiBan}|{donHang.LienHeNguoiBan}|{donHang.SDTNguoiBan}|{donHang.SDTNguoiMua}|{donHang.DiaDiemNhan}|{donHang.TenNguoiMua}|{donHang.DiaDiemGiao}|{donHang.TienThuHo}|{donHang.GhiChu}");
                var smtp = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential("binhdinhexphanmem@gmail.com", "binhdinhex769799"),
                    EnableSsl = true
                };
                smtp.Send(mail);
                DonHangTamBUS.ThemDonHangTam ( donHang );
                string url3 = $"http://kienuit.esy.es/xoa_hang.php?Ma={donHang.MaDonHangTam}";
                HttpWebRequest request3 = (HttpWebRequest)WebRequest.Create(url3);
                HttpWebResponse response3 = (HttpWebResponse)request3.GetResponse();
            }

        }

        public void AddApprovedRow ( )
        {
            DonHangChinhThucList.Add ( new DonHangChinhThuc() );
        }

        public void CapNhatDonHang()
        {
            var dialog = IoC.Get<DialogViewModel>();
            dialog.Question = "Cập nhật các đơn hàng này?";
            dialog.DisplayName = "";

            var result = _windowManager.ShowDialog(dialog);

            if (result != true)
            {
                return;
            }

            var removeList = new List < DonHangChinhThuc > ();
            foreach ( var donHang in DonHangChinhThucList )
            {
                var tmp = new DonHangDTO
                {
                    MaDonHang = donHang.MaDonHang,
                    LienHeNguoiBan = donHang.LienHeNguoiBan,
                    DiaDiemGiao = donHang.DiaDiemGiaoHang,
                    DiaDiemNhan = donHang.DiaDiemNhanHang,
                    GhiChu = donHang.GhiChu,
                    KhuVuc = donHang.TenKhuVuc.ToString ( ),
                    LoaiDonHang = donHang.TenLoaiDonHang.ToString ( ),
                    MaNhanVienGiao = donHang.MaNhanVienGiao,
                    MaNhanVienNhan = donHang.MaNhanVienNhan,
                    NgayDatHang = donHang.NgayDatHang,
                    TenNguoiMua = donHang.TenNguoiMua,
                    TenNguoiBan = donHang.TenNguoiBan,
                    TienThuHo = donHang.TienThuHo,
                    TrangThai = donHang.TenTrangThai.ToString ( ),
                    SDTNguoiBan = donHang.SdtNguoiBan,
                    SDTNguoiMua = donHang.SdtNguoiMua,
                    TongThanhTien = donHang.TongThanhTien,
                    NgayGiaoHang = donHang.NgayGiaoHang,
                    NgayNhanHang = donHang.NgayNhanHang,
                    PhiVanChuyen = donHang.PhiVanChuyen,
                    PhiPhatSinh = donHang.PhiPhatSinh
                };

                try
                {
                    var mail = new MailMessage("binhdinhexphanmem@gmail.com", "binhdinhexthongbaophanmem@gmail.com", "[Đơn hàng đã xác nhận]" + donHang.MaDonHang,
                        $"{donHang.MaDonHang}|{donHang.TenLoaiDonHang}|{donHang.TenKhuVuc}|{donHang.NgayDatHang}|{donHang.NgayNhanHang}|{donHang.NgayGiaoHang}|{donHang.TenTrangThai}|{donHang.MaNhanVienNhan}|{donHang.MaNhanVienGiao}|{donHang.TenNguoiBan}|{donHang.LienHeNguoiBan}|{donHang.SdtNguoiBan}|{donHang.DiaDiemNhanHang}|{donHang.TenNguoiMua}|{donHang.SdtNguoiMua}|{donHang.DiaDiemGiaoHang}|{donHang.TienThuHo}|{donHang.PhiVanChuyen}|{donHang.PhiPhatSinh}|{donHang.TongThanhTien}");
                    var smtp = new SmtpClient()
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        Credentials = new NetworkCredential("binhdinhexphanmem@gmail.com", "binhdinhex769799"),
                        EnableSsl = true
                    };
                    smtp.Send(mail);
                    DonHangBUS.ThemDonHang(tmp);
                    removeList.Add(donHang);
                }
                catch ( Exception e )
                {
                    if ( e is SmtpException )
                    {
                        var error = IoC.Get < ErrorViewModel > ( );
                        error.ErrorName = "Có vấn đề về mạng";
                        error.DisplayName = "Lỗi";
                        _windowManager.ShowDialog ( error );
                    }
                    else
                    {
                        var error = IoC.Get<ErrorViewModel>();
                        error.ErrorName = e.Message;
                        error.DisplayName = "Lỗi";
                        _windowManager.ShowDialog(error);
                    }
                }
            }

            _baseMaDonHangChinhThuc = DonHangBUS.GenerateNewMaDonHang ( );
            foreach ( var donHang in removeList )
            {
                DonHangChinhThucList.Remove ( donHang );
            }
        }
    }
}
