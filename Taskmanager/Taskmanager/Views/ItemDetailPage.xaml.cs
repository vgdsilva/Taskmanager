using System.ComponentModel;
using Taskmanager.ViewModels;
using Xamarin.Forms;

namespace Taskmanager.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}