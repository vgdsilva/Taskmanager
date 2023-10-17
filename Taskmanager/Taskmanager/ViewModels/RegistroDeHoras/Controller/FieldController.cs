using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taskmanager.ViewModels.RegistroDeHoras.Controller
{
    public partial class FieldController : ObservableObject
    {
        [ObservableProperty]
        public string nomenclaturaBotaoPrimario = "Iniciar";
    }
}
