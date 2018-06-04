using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

namespace GUI.ViewModels
{
    public sealed class AppViewModel: Conductor <object>.Collection.OneActive
    {
        public AppViewModel ( )
        {
            ActivateItem ( new StartupViewModel (  ) );
        }

        public void ApproveDonHang()
        {
            ActivateItem(new ApproveDonHangViewModel());
        }

        public void NhanDonHang()
        {
            ActivateItem(new NhanHangViewModel());
        }

        public void GiaoDonHang()
        {
            ActivateItem(new GiaoHangViewModel());
        }

        public void TongKet()
        {
            ActivateItem(new TongKetViewModel());
        }

        public void TaiKhoan()
        {
            ActivateItem(new DangNhapViewModel());
        }

        public void QuyDinh()
        {
            ActivateItem(new QuyDinhViewModel());
        }

        public void NhanVien()
        {
            ActivateItem(new NhanVienViewModel());
        }
    }
}
