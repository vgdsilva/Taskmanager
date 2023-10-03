using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taskmanager.Mobile.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InputTextEdit : Grid
    {
        public InputTextEdit()
        {
            InitializeComponent();
        }
    }
}