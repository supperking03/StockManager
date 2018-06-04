using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

namespace GUI.ViewModels
{
    [Export(typeof(ErrorViewModel))]
    class ErrorViewModel: Screen
    {
        private string _errorName;
        public string ErrorName
        {
            get
            {
                return _errorName;
            }
            set
            {
                _errorName = value;
                NotifyOfPropertyChange(() => ErrorName);
            }
        }
    }
}
