using Gasolin.Desktop.Properties;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gasolin.Desktop.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {

        }

        public string WindowTitle => $"Gasoline v{Resources.Version}";

        
    }
}
