using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Taskmanager.Models;
using Taskmanager.Services;
using Xamarin.Forms;

namespace Taskmanager.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        [ObservableProperty]
        protected bool isBusy = false;

        [ObservableProperty]
        public string title;
    }
}
