using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BUS;

using Caliburn.Micro;

namespace GUI.ViewModels
{
    [Export(typeof(QuyDinhViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    class QuyDinhViewModel: PropertyChangedBase
    {
        private double _phiVanChuyenTrenKm;
        private double _phiThuHo;

        private readonly WindowManager _windowManager;

        public QuyDinhViewModel ( )
        {
            _windowManager = new WindowManager (  );
            RefreshThamSo(  );
        }

        private void RefreshThamSo ( )
        {
            PhiVanChuyenTrenKm = ThamSoBUS.GetSoTienTrenKm();
            PhiThuHo = ThamSoBUS.GetPhiThuHo();
        }

        public void CapNhat ( )
        {
            var dialog = IoC.Get<DialogViewModel>();
            dialog.Question = "Xác nhận đơn hàng đã chọn?";
            dialog.DisplayName = "";

            var result = _windowManager.ShowDialog(dialog);

            if (result != true)
            {
                return;
            }

            ThamSoBUS.UpdatePhiThuHo ( PhiThuHo );
            ThamSoBUS.UpdateSoTienTrenKm ( PhiVanChuyenTrenKm );

            Refresh (  );
        }

        public double PhiVanChuyenTrenKm
        {
            get
            {
                return _phiVanChuyenTrenKm;
            }
            set
            {
                _phiVanChuyenTrenKm = value;
                NotifyOfPropertyChange ( ()=>PhiVanChuyenTrenKm );
            }
        }

        public double PhiThuHo
        {
            get
            {
                return _phiThuHo;
            }
            set
            {
                _phiThuHo = value;
                NotifyOfPropertyChange(() => PhiThuHo);
            }
        }
    }
}
