using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Taskmanager.Mobile.ViewModels.RegistroDeHoras.Cronometro
{
    public partial class RegistroDeHorasCronometroViewModel : BaseViewModel
    {

        [ObservableProperty]
        public string descricaoButtonInitTask;

        [ObservableProperty]
        private TimeSpan runningTotal;

        [ObservableProperty]
        private bool isTaskRunning = false;

        [ObservableProperty]
        private DateTime currentStartTime;

        private Timer _timer;

        public RegistroDeHorasCronometroViewModel()
        {
            Title = "Registro de Horas - Cronometradas";
            DescricaoButtonInitTask = "Iniciar Task";

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Enabled = false;
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RunningTotal += TimeSpan.FromSeconds(1);
        }

        public override void OnAppearing()
        {
            base.OnAppearing();

            RunningTotal = new TimeSpan();
        }

        [RelayCommand]
        public async void InitTaskOrStopTask()
        {
            if ( IsBusy )
                return;

            IsBusy = true;

            if ( IsTaskRunning )
            {
                DescricaoButtonInitTask = "Iniciar Task";
                _timer.Enabled = false;
                RunningTotal = TimeSpan.Zero;

            }
            else
            {
                DescricaoButtonInitTask = "Parar Task";
                CurrentStartTime = DateTime.Now;
                _timer.Enabled = true;
            }

            IsTaskRunning = !IsTaskRunning;

            IsBusy = false;
        }

    }
}
