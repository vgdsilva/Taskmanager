using CommunityToolkit.Mvvm.ComponentModel;
using Taskmanager.Mobile.Models;
using Taskmanager.Mobile.Services;
using Xamarin.Forms;

namespace Taskmanager.Mobile.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        [ObservableProperty]
        public bool isBusy = false;

        [ObservableProperty]
        public string title;

        public BaseViewModel()
        {
            
        }

        public virtual void OnAppearing() { }

        public virtual void OnDisappearing() { }
    }
}
