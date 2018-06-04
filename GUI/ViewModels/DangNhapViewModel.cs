using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BUS;

using Caliburn.Micro;

using DTO;

using GUI.Enums;
using GUI.Singletons;

namespace GUI.ViewModels
{
    [Export(typeof(DangNhapViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class DangNhapViewModel: PropertyChangedBase
    {
        private string _userName;
        private string _password;

        private WindowManager _windowManager;

        public DangNhapViewModel ( )
        {
            _windowManager = new WindowManager (  );
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                NotifyOfPropertyChange ( ()=>Password );
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                NotifyOfPropertyChange ( ()=> UserName );
            }
        }

        public void Logout ( )
        {
            User.Instance.CurrentUserType = UserType.Khach;
            User.Instance.CurrentUsername = "";
        }

        public void Login()
        {
            var tmp = TaiKhoanBUS.SelectTaiKhoanByTenTaiKhoan (UserName);

            if ( tmp == null )
            {
                var error = IoC.Get<ErrorViewModel>();
                error.ErrorName = "Tài khoản không tồn tại";
                error.DisplayName = "Lỗi";
                _windowManager.ShowDialog(error);
            }
            else
            {
                if ( tmp.MatKhau == Password )
                {
                    User.Instance.CurrentUserType = (UserType) Enum.Parse(typeof(UserType), tmp.LoaiTaiKhoan);
                    User.Instance.CurrentUsername = tmp.TenTaiKhoan;
                }
                else
                {
                    var error = IoC.Get<ErrorViewModel>();
                    error.ErrorName = "Mật khẩu không đúng";
                    error.DisplayName = "Lỗi";
                    _windowManager.ShowDialog(error);
                }
            }
        }
    }
}
