using System;
using System.Collections.Generic;
using System.ComponentModel;
using Taskmanager.Models;
using Taskmanager.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taskmanager.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}