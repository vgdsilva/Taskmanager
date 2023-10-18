using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Taskmanager.Models.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Taskmanager.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarDaysView : StackLayout
	{
		public static readonly BindableProperty SelectedDateProperty = BindableProperty.Create(
			nameof(SelectedDate),
			typeof(DateTime),
			declaringType: typeof(CalendarDaysView),
			defaultBindingMode: BindingMode.TwoWay,
			defaultValue: DateTime.Now,
			propertyChanged: SelectedDatePropertyChanged
		);

        private static void SelectedDatePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controls = (CalendarDaysView)bindable;
			if (newValue != null )
			{
				var newDate = (DateTime)newValue;
				//controls.BindDate(newDate);
			}
        }

        public DateTime SelectedDate 
		{ 
			get => (DateTime)GetValue(SelectedDateProperty); 
			set => SetValue(SelectedDateProperty, value); 
		}

		private DateTime _tempData;

        public ObservableCollection<CalendarModel> Dates { get; set; } = new ObservableCollection<CalendarModel>();

		public CalendarDaysView ()
		{
			InitializeComponent ();
			BindDate(DateTime.Now);
		}

		private void BindDate(DateTime date)
		{
			Dates.Clear();
			int daysOfTheMonth = DateTime.DaysInMonth(date.Year, date.Month);
			for ( int days = 1; days <= daysOfTheMonth; days++ )
			{
				Dates.Add(new CalendarModel { Date = new DateTime(date.Year, date.Month, days), IsCurrentDate = date.Day == days });
			}

			var selectedDate = Dates.FirstOrDefault(f => f.Date.Date == SelectedDate.Date);
            if ( selectedDate != null)
				_tempData = selectedDate.Date;

		}

		public ICommand CurrentDateCommand => new Command<CalendarModel>((currentDate) =>
		{
			_tempData = currentDate.Date;
			SelectedDate = currentDate.Date;
			Dates.ForEach(d => d.IsCurrentDate = false);
			currentDate.IsCurrentDate = true;
		});
		
		public ICommand NextMonthCommand => new Command(() =>
		{
			_tempData = _tempData.AddMonths(1);
            BindDate(_tempData);
        });
		
		public ICommand PreviousMonthCommand => new Command(() =>
		{
            _tempData = _tempData.AddMonths(-1);
			BindDate(_tempData);
        });
	}
}