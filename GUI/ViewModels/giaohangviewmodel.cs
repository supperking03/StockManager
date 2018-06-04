using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;

using BUS;

using Caliburn.Micro;

using DTO;

using GUI.Enums;
using GUI.Models;


namespace GUI.ViewModels
{
    [Export(typeof(GiaoHangViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class GiaoHangViewModel : PropertyChangedBase
    {
        private readonly WindowManager _windowManager;

        private ObservableCollection<DonHangGiaoNhan> _donHangGiaoList;

        private DonHangGiaoNhan _selectedDonHangGiao;

        public GiaoHangViewModel()
        {
            _windowManager = new WindowManager();

            DonHangGiaoList = new ObservableCollection<DonHangGiaoNhan>();
            RefreshDonHang();
        }

        public ObservableCollection<DonHangGiaoNhan> DonHangGiaoList
        {
            get
            {
                return _donHangGiaoList;
            }
            set
            {
                _donHangGiaoList = value;
                NotifyOfPropertyChange(() => DonHangGiaoList);
            }
        }

        public DonHangGiaoNhan SelectedDonHangGiao
        {
            get
            {
                return _selectedDonHangGiao;
            }
            set
            {
                _selectedDonHangGiao = value;
                NotifyOfPropertyChange(() => SelectedDonHangGiao);
            }
        }

        public void RefreshDonHang()
        {
            DonHangGiaoList.Clear();
            foreach (var donHang in DonHangBUS.SelectDonHangByTrangThai(TrangThai.DaNhanHang.ToString()))
            {
                DonHangGiaoList.Add(new DonHangGiaoNhan(donHang));
            }
        }

        public void CompleteDonHang()
        {
            if (SelectedDonHangGiao == null)
            {
                return;
            }

            var dialog = IoC.Get<DialogViewModel>();
            dialog.Question = "Hoàn tất giao đơn hàng đã chọn?";
            dialog.DisplayName = "";

            var result = _windowManager.ShowDialog(dialog);

            if (result != true)
            {
                return;
            }

            SelectedDonHangGiao.TenTrangThai = TrangThai.DaGiaoHang;

            var donHang = SelectedDonHangGiao;

            var tmp = new DonHangDTO
            {
                MaDonHang = donHang.MaDonHang,
                LienHeNguoiBan = donHang.LienHeNguoiBan,
                DiaDiemGiao = donHang.DiaDiemGiaoHang,
                DiaDiemNhan = donHang.DiaDiemGiaoHang,
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
                DonHangGiaoList.Remove(SelectedDonHangGiao);
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
            if (SelectedDonHangGiao == null)
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

            SelectedDonHangGiao.TenTrangThai = TrangThai.DaHuy;

            var donHang = SelectedDonHangGiao;

            var tmp = new DonHangDTO
            {
                MaDonHang = donHang.MaDonHang,
                LienHeNguoiBan = donHang.LienHeNguoiBan,
                DiaDiemGiao = donHang.DiaDiemGiaoHang,
                DiaDiemNhan = donHang.DiaDiemGiaoHang,
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
                DonHangGiaoList.Remove(SelectedDonHangGiao);
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


            appExcel.Range[appExcel.Cells[1, 1], appExcel.Cells[1, 1]].RowHeight = 150;

            appExcel.Cells[2, 1].EntireRow.Font.Bold = true;
            appExcel.Cells[3, 1].EntireRow.Font.Bold = true;
            appExcel.Cells[4, 1].EntireRow.Font.Bold = true;


            appExcel.ActiveSheet.Shapes.AddPicture(@"C:\Users\NAM\Desktop\BDElogo.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, (float)((double)appExcel.Cells[1, 6].Left), 30, 100, 100);


            for (int i = 4; i < DonHangGiaoList.Count + 5; i++)
                for (int j = 1; j <= 11; j++)
                {
                    var appExcelBorderRange = appExcel.Range[appExcel.Cells[i, j], appExcel.Cells[i, j]];
                    Microsoft.Office.Interop.Excel.Borders border = appExcelBorderRange.Borders;
                    border[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    border[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    border[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    border[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                }
            appExcel.Range[appExcel.Cells[4, 1], appExcel.Cells[DonHangGiaoList.Count + 5, 11]].Wraptext = true;

            appExcel.Range[appExcel.Cells[1, 1], appExcel.Cells[1, 11]].Merge();
            appExcel.Range[appExcel.Cells[2, 1], appExcel.Cells[2, 11]].Merge();
            appExcel.Range[appExcel.Cells[2, 1], appExcel.Cells[2, 11]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            appExcel.Range[appExcel.Cells[3, 1], appExcel.Cells[3, 11]].Merge();
            appExcel.Range[appExcel.Cells[3, 1], appExcel.Cells[3, 11]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            appExcel.Range[appExcel.Cells[4, 1], appExcel.Cells[4, 11]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            appExcel.Range[appExcel.Cells[4, 1], appExcel.Cells[4, 11]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            appExcel.Cells[2, 1] = "BinhDinhExpress Thuộc Công Ty TNHH Thương Mại Và Dịch Vụ Vận Chuyển ĐẠT KHANG";
            appExcel.Cells[3, 1] = "DANH SÁCH GIAO HÀNG";
            appExcel.Cells[4, 1] = "Mã nhân viên giao";
            appExcel.Cells[4, 2] = "Khu Vực";
            appExcel.Cells[4, 3] = "Loại Hàng";
            appExcel.Cells[4, 4] = "Tên người nhận";
            appExcel.Cells[4, 5] = "Địa chỉ người nhận";
            appExcel.Cells[4, 6] = "Số điện thoại người nhận";
            appExcel.Cells[4, 7] = "Tiền thu hộ";
            appExcel.Cells[4, 8] = "Tổng tiền";
            appExcel.Cells[4, 9] = "Ghi chú";
            appExcel.Cells[4, 10] = "Chữ kí người nhận";
            appExcel.Cells[4, 11] = "Chữ kí nhân viên";

            for (int i = 0; i < DonHangGiaoList.Count; i++)
            {
                appExcel.Cells[i + 5, 1] = DonHangGiaoList[i].MaNhanVienGiao;
                appExcel.Cells[i + 5, 2] = DonHangGiaoList[i].TenKhuVuc;
                appExcel.Cells[i + 5, 3] = DonHangGiaoList[i].TenLoaiDonHang;
                appExcel.Cells[i + 5, 4] = DonHangGiaoList[i].TenNguoiMua;
                appExcel.Cells[i + 5, 5] = DonHangGiaoList[i].DiaDiemGiaoHang;
                appExcel.Cells[i + 5, 6] = DonHangGiaoList[i].SdtNguoiMua;
                appExcel.Cells[i + 5, 7] = DonHangGiaoList[i].TienThuHo;
                appExcel.Cells[i + 5, 8] = DonHangGiaoList[i].TongThanhTien;
                appExcel.Cells[i + 5, 9] = DonHangGiaoList[i].GhiChu;
                appExcel.Cells[i + 5, 10] = "";
                appExcel.Cells[i + 5, 11] = "";
            }

            appExcel.Visible = true;
        }
    }
}
