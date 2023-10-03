using System;
using Taskmanager.Mobile.Services;
using Taskmanager.Mobile.Views;
using Taskmanager.Mobile.Views.Pages.RegistroDeHoras.Cronometro;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taskmanager.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage( new RegistroDeHorasCronometroPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
