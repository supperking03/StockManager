using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

namespace GUI.ViewModels
{
    [Export(typeof(DialogViewModel))]
    class DialogViewModel: Screen
    {
        private string _question;
        public string Question
        {
            get
            {
                return _question;
            }
            set
            {
                _question = value;
                NotifyOfPropertyChange(() => Question);
            }
        }

        public void Ok()
        {
            TryClose(true);
        }

        public void Cancel()
        {
            TryClose(false);
        }
    }
}
