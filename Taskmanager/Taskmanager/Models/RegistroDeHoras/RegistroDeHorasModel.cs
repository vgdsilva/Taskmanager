using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taskmanager.Models.RegistroDeHoras
{
    public partial class RegistroDeHorasModel : BaseModels
    {

        [ObservableProperty]
        public string dataTarefa;

        [ObservableProperty]
        public string tipoAtividade;

        [ObservableProperty]
        public string descricao;
    }
}
