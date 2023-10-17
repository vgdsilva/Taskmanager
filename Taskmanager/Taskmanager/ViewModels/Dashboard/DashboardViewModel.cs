using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using Taskmanager.Views.RegistroDeHoras;
using Xamarin.Forms;

namespace Taskmanager.ViewModels.Dashboard
{
    public partial class DashboardViewModel : BaseViewModel
    {
        public DashboardViewModel()
        {
            
        }


        [RelayCommand]
        private async void AddNewTask()
        {
            await Shell.Current.GoToAsync(nameof(RegistroDeHoraPage));
        }
    }
}
