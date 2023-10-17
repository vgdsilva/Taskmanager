using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Timers;
using Taskmanager.Models.RegistroDeHoras;
using Taskmanager.ViewModels.RegistroDeHoras.Controller;

namespace Taskmanager.ViewModels.RegistroDeHoras
{
    public partial class RegistroDeHoraViewModel : BaseViewModel
    {

        [ObservableProperty] 
        private FieldController fieldController;

        [ObservableProperty] 
        private RegistroDeHorasModel model;
        
        [ObservableProperty] 
        private bool isClockedIn;

        [ObservableProperty] 
        private TimeSpan runningTotal;

        private Timer _timer;

        public RegistroDeHoraViewModel()
        {
            Title = "Nova Tarefa";
            FieldController = new FieldController();
            Model = new RegistroDeHorasModel();

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Enabled = false;
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RunningTotal += TimeSpan.FromSeconds(1);
        }

        [RelayCommand]
        private async void StartOrStopTimer()
        {
            if ( IsClockedIn )
            {
                _timer.Enabled = false;
                RunningTotal = TimeSpan.Zero;
                FieldController.NomenclaturaBotaoPrimario = "Iniciar";
            }
            else
            {
                if (string.IsNullOrEmpty(Model.DataTarefa) && string.IsNullOrEmpty(Model.TipoAtividade) && string.IsNullOrEmpty(Model.Descricao))
                    return;

                _timer.Enabled = true;
                FieldController.NomenclaturaBotaoPrimario = "Parar";
                
            }

            IsClockedIn = !IsClockedIn;
        }
    }
}
