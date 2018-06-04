using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;

using BUS;

using Caliburn.Micro;

using DTO;
using System.Windows.Media.Imaging;
using GUI.Enums;
using GUI.Models;
using Microsoft.Office.Interop;
using System.IO;


namespace GUI.ViewModels
{
    [Export(typeof(NhanHangViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class NhanHangViewModel : PropertyChangedBase
    {
        private readonly WindowManager _windowManager;

        private ObservableCollection<DonHangGiaoNhan> _donHangNhanList;

        private DonHangGiaoNhan _selectedDonHangNhan;

        public NhanHangViewModel()
        {
            _windowManager = new WindowManager();

            DonHangNhanList = new ObservableCollection<DonHangGiaoNhan>();
            RefreshDonHang();
        }




        public ObservableCollection<DonHangGiaoNhan> DonHangNhanList
        {
            get
            {
                return _donHangNhanList;
            }
            set
            {
                _donHangNhanList = value;
                NotifyOfPropertyChange(() => DonHangNhanList);
            }
        }

        public DonHangGiaoNhan SelectedDonHangNhan
        {
            get
            {
                return _selectedDonHangNhan;
            }
            set
            {
                _selectedDonHangNhan = value;
                NotifyOfPropertyChange(() => SelectedDonHangNhan);
            }
        }

        public void RefreshDonHang()
        {
            DonHangNhanList.Clear();
            foreach (var donHang in DonHangBUS.SelectDonHangByTrangThai(TrangThai.DaXacNhan.ToString()))
            {
                DonHangNhanList.Add(new DonHangGiaoNhan(donHang));
            }
        }

        public void CompleteDonHang()
        {
            if (SelectedDonHangNhan == null)
            {
                return;
            }

            var dialog = IoC.Get<DialogViewModel>();
            dialog.Question = "Hoàn tất nhận đơn hàng đã chọn?";
            dialog.DisplayName = "";

            var result = _windowManager.ShowDialog(dialog);

            if (result != true)
            {
                return;
            }

            SelectedDonHangNhan.TenTrangThai = TrangThai.DaNhanHang;

            var donHang = SelectedDonHangNhan;

            var tmp = new DonHangDTO
            {
                MaDonHang = donHang.MaDonHang,
                LienHeNguoiBan = donHang.LienHeNguoiBan,
                DiaDiemGiao = donHang.DiaDiemGiaoHang,
                DiaDiemNhan = donHang.DiaDiemNhanHang,
                GhiChu = donHang.GhiChu,
                KhuVuc = donHang.TenKhuVuc.ToString(),
                LoaiDonHang = donHang.TenLoaiDonHang.ToString(),
                MaNhanVienGiao = donHang.MaNhanVienGiao,
                MaNhanVienNhan = donHang.MaNhanVienNhan,
                NgayDatHang = donHang.NgayDatHang,
                TenNguoiMua = donHang.TenNguoiMua,
                TenNguoiBan = donHang.TenNguoiBan,
                TienThuHo = donHang.TienThuHo,
                TrangThai = donHang.TenTrangThai.ToString(),
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
                DonHangBUS.SuaDonHang(tmp);
                DonHangNhanList.Remove(SelectedDonHangNhan);
            }
            catch (Exception e)
            {
                var error = IoC.Get<ErrorViewModel>();
                error.ErrorName = e.Message;
                error.DisplayName = "Lỗi";
                _windowManager.ShowDialog(error);
            }
        }

        public void RemoveDonHang()
        {
            if (SelectedDonHangNhan == null)
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

            SelectedDonHangNhan.TenTrangThai = TrangThai.DaHuy;

            var donHang = SelectedDonHangNhan;

            var tmp = new DonHangDTO
            {
                MaDonHang = donHang.MaDonHang,
                LienHeNguoiBan = donHang.LienHeNguoiBan,
                DiaDiemGiao = donHang.DiaDiemGiaoHang,
                DiaDiemNhan = donHang.DiaDiemNhanHang,
                GhiChu = donHang.GhiChu,
                KhuVuc = donHang.TenKhuVuc.ToString(),
                LoaiDonHang = donHang.TenLoaiDonHang.ToString(),
                MaNhanVienGiao = donHang.MaNhanVienGiao,
                MaNhanVienNhan = donHang.MaNhanVienNhan,
                NgayDatHang = donHang.NgayDatHang,
                TenNguoiMua = donHang.TenNguoiMua,
                TenNguoiBan = donHang.TenNguoiBan,
                TienThuHo = donHang.TienThuHo,
                TrangThai = donHang.TenTrangThai.ToString(),
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
                DonHangBUS.SuaDonHang(tmp);
                DonHangNhanList.Remove(SelectedDonHangNhan);
            }
            catch (Exception e)
            {
                var error = IoC.Get<ErrorViewModel>();
                error.ErrorName = e.Message;
                error.DisplayName = "Lỗi";
                _windowManager.ShowDialog(error);
            }
        }

        public void Print()
        {

            Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.Application.Workbooks.Add(Type.Missing);
            
            appExcel.ActiveWindow.DisplayGridlines = false;


            appExcel.Columns.ColumnWidth = 15;
            appExcel.Rows.RowHeight = 30;


            appExcel.Range[appExcel.Cells[1, 1], appExcel.Cells[1, 1]].RowHeight=150;

            appExcel.Cells[2, 1].EntireRow.Font.Bold = true;
            appExcel.Cells[3, 1].EntireRow.Font.Bold = true;
            appExcel.Cells[4, 1].EntireRow.Font.Bold = true;

            

            
            appExcel.ActiveSheet.Shapes.AddPicture(Path.GetFullPath("BDElogo.jpg"), Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, (float)((double)appExcel.Cells[1,6].Left),30, 100, 100);


            for (int i = 4; i < DonHangNhanList.Count + 5; i++)
                for (int j = 1; j <= 11; j++)
                {
                    var appExcelBorderRange = appExcel.Range[appExcel.Cells[i, j], appExcel.Cells[i, j]];
                    Microsoft.Office.Interop.Excel.Borders border = appExcelBorderRange.Borders;
                    border[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    border[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    border[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    border[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                }
            appExcel.Range[appExcel.Cells[4, 1], appExcel.Cells[DonHangNhanList.Count+5, 11]].Wraptext=true;

            appExcel.Range[appExcel.Cells[1, 1], appExcel.Cells[1, 11]].Merge();
            appExcel.Range[appExcel.Cells[2, 1], appExcel.Cells[2, 11]].Merge();
            appExcel.Range[appExcel.Cells[2, 1], appExcel.Cells[2, 11]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            appExcel.Range[appExcel.Cells[3, 1], appExcel.Cells[3, 11]].Merge();
            appExcel.Range[appExcel.Cells[3, 1], appExcel.Cells[3, 11]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            appExcel.Range[appExcel.Cells[4, 1], appExcel.Cells[4, 11]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            appExcel.Range[appExcel.Cells[4, 1], appExcel.Cells[4, 11]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            appExcel.Cells[2, 1] = "BinhDinhExpress Thuộc Công Ty TNHH Thương Mại Và Dịch Vụ Vận Chuyển ĐẠT KHANG";
            appExcel.Cells[3, 1] = "DANH SÁCH NHẬN HÀNG";
            appExcel.Cells[4, 1] = "Mã nhân viên nhận";
            appExcel.Cells[4, 2] = "Khu Vực";
            appExcel.Cells[4, 3] = "Loại Hàng";
            appExcel.Cells[4, 4] = "Tên khách đặt giao";
            appExcel.Cells[4, 5] = "Địa chỉ khách đặt giao";
            appExcel.Cells[4, 6] = "Số điện thoại khách đặt giao";
            appExcel.Cells[4, 7] = "Tiền thu hộ";
            appExcel.Cells[4, 8] = "Tổng tiền";
            appExcel.Cells[4, 9] = "Ghi chú";
            appExcel.Cells[4, 10] = "Chữ kí khách hàng ";
            appExcel.Cells[4, 11] = "Chữ kí nhân viên";

            for (int i = 0; i < DonHangNhanList.Count; i++)
            {
                appExcel.Cells[i + 5, 1] = DonHangNhanList[i].MaNhanVienNhan;
                appExcel.Cells[i + 5, 2] = DonHangNhanList[i].TenKhuVuc;
                appExcel.Cells[i + 5, 3] = DonHangNhanList[i].TenLoaiDonHang;
                appExcel.Cells[i + 5, 4] = DonHangNhanList[i].TenNguoiBan;
                appExcel.Cells[i + 5, 5] = DonHangNhanList[i].DiaDiemNhanHang;
                appExcel.Cells[i + 5, 6] = DonHangNhanList[i].SdtNguoiBan;
                appExcel.Cells[i + 5, 7] = DonHangNhanList[i].TienThuHo;
                appExcel.Cells[i + 5, 8] = DonHangNhanList[i].TongThanhTien;
                appExcel.Cells[i + 5, 9] = DonHangNhanList[i].GhiChu;
                appExcel.Cells[i + 5, 10] = "";
                appExcel.Cells[i + 5, 11] = "";
            }

            appExcel.Visible = true;


        }



    }
}
