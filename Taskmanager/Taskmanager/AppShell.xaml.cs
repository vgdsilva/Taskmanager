using System;
using System.Collections.Generic;
using Taskmanager.ViewModels;
using Taskmanager.Views;
using Taskmanager.Views.RegistroDeHoras;
using Xamarin.Forms;

namespace Taskmanager
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RegistroDeHoraPage), typeof(RegistroDeHoraPage));
        }

    }
}
