using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

using DTO;

namespace GUI.Models
{
    class NhanVien: PropertyChangedBase
    {
        private string _maNhanVien;
        private string _tenNhanVien;

        public NhanVien ( )
        {
            
        }

        public NhanVien ( NhanVienDTO nhanVien )
        {
            MaNhanVien = nhanVien.MaNhanVien;
            TenNhanVien = nhanVien.TenNhanVien;
        }

        public string MaNhanVien
        {
            get
            {
                return _maNhanVien;
            }
            set
            {
                _maNhanVien = value;
                NotifyOfPropertyChange ( ( ) => MaNhanVien );
            }
        }

        public string TenNhanVien
        {
            get
            {
                return _tenNhanVien;
            }
            set
            {
                _tenNhanVien = value;
                NotifyOfPropertyChange ( ( ) => TenNhanVien );
            }
        }
    }
}
