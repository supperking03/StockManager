using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

using GUI.Enums;

namespace GUI.Singletons
{
    public class User: PropertyChangedBase
    {
        private static User _instance;

        private string _currentUsername;

        private UserType _currentUserType;

        public static User Instance
        {
            get
            {
                return _instance ?? ( _instance = new User ( ) );
            }
        }

        public string CurrentUsername
        {
            get
            {
                return _currentUsername;
            }
            set
            {
                _currentUsername = value;
                NotifyOfPropertyChange ( ()=> CurrentUsername);
            }
        }

        public UserType CurrentUserType
        {
            get
            {
                return _currentUserType;
            }
            set
            {
                _currentUserType = value;
                NotifyOfPropertyChange ( ()=> CurrentUserType );
            }
        }

        private User ( )
        {
            _currentUsername = "";
            _currentUserType = UserType.Khach;
        }
    }
}
