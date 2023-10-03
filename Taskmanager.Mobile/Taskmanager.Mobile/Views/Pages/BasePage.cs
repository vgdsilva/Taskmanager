using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskmanager.Mobile.ViewModels;
using Xamarin.Forms;

namespace Taskmanager.Mobile.Views.Pages
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ( BindingContext as BaseViewModel )?.OnAppearing();
        }

        protected override void OnDisappearing() 
        {
            ( BindingContext as BaseViewModel )?.OnDisappearing();
            base.OnDisappearing(); 
        }
    }
}