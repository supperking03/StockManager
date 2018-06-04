using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

namespace GUI.ViewModels
{
    [Export(typeof(QuyDinhViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    class StartupViewModel: PropertyChangedBase
    {
    }
}
