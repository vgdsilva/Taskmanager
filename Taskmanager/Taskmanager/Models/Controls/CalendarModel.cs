using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taskmanager.Models.Controls
{
    public partial class CalendarModel : ObservableObject
    {
        public DateTime Date { get; set; }

        [ObservableProperty]
        private bool isCurrentDate;
    }
}
