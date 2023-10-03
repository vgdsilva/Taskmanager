using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace Taskmanager.Mobile.Models.Task
{
    public partial class TaskModel : BaseModel
    {
        [ObservableProperty]
        public int iDTask;

        [ObservableProperty]
        public string descricao;

        [ObservableProperty]
        public string tipoAtivodade;

        [ObservableProperty]
        public DateTime data;

        [ObservableProperty]
        public DateTime dataHoraInicio;

        [ObservableProperty]
        public DateTime dataHoraTermino;

        private TimeSpan TempoGasto;
        public string TempoGastoFormatado => TempoGasto != null ? TempoGasto.ToString(@"hh\:mm") : string.Empty;


        public TaskModel()
        {
            
        }

        public void CalcularTempoGastoTask()
        {
            TempoGasto = DataHoraTermino- DataHoraInicio;
        }
    }
}
