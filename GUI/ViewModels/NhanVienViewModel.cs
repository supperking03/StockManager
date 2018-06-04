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

using GUI.Models;

namespace GUI.ViewModels
{
    [Export(typeof(NhanVienViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    class NhanVienViewModel: PropertyChangedBase
    {
        private ObservableCollection < NhanVien > _listNhanVien;
        private NhanVien _selectedNhanVien;

        private WindowManager _windowManager;

        public NhanVienViewModel( )
        {
            ListNhanVien = new ObservableCollection < NhanVien > ();
            NhanVienBUS.SelectNhanVienAll ( ).ForEach ( x => ListNhanVien.Add ( new NhanVien ( x ) ) );
            _windowManager = new WindowManager (  );
        }


        public ObservableCollection < NhanVien > ListNhanVien
        {
            get
            {
                return _listNhanVien;
            }
            set
            {
                _listNhanVien = value;
                NotifyOfPropertyChange ( ()=>ListNhanVien );
            }
        }

        public NhanVien SelectedNhanVien
        {
            get
            {
                return _selectedNhanVien;
            }
            set
            {
                _selectedNhanVien = value;
                NotifyOfPropertyChange ( ( ) => SelectedNhanVien );
            }
        }

        public void ThemNhanVien ( )
        {
            ListNhanVien.Add ( new NhanVien() );
        }

        public void XoaNhanVien ( )
        {
            ListNhanVien.Remove ( SelectedNhanVien );
        }

        public void CapNhat ( )
        {
            NhanVienBUS.XoaMoiNhanVien ( );

            foreach ( var nhanVien in ListNhanVien )
            {
                NhanVienDTO tmp = new NhanVienDTO
                {
                    MaNhanVien = nhanVien.MaNhanVien,
                    TenNhanVien = nhanVien.TenNhanVien
                };

                try
                {
                    NhanVienBUS.ThemNhanVien(tmp);
                }
                catch ( Exception e )
                {
                    var error = IoC.Get<ErrorViewModel>();
                    error.ErrorName = e.Message;
                    error.DisplayName = "Lỗi";
                    _windowManager.ShowDialog(error);
                }
            }

            ListNhanVien.Clear (  );
            NhanVienBUS.SelectNhanVienAll().ForEach(x => ListNhanVien.Add(new NhanVien(x)));
        }
    }
}
