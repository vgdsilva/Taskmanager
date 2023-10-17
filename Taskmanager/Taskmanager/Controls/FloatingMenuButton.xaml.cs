using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taskmanager.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FloatingMenuButton : StackLayout
	{
		public FloatingMenuButton ()
		{
			InitializeComponent ();
		}

        #region MainButtonText
        public static readonly BindableProperty MainButtonTextProperty = BindableProperty.Create(nameof(MainButtonText), typeof(string), typeof(FloatingMenuButton), defaultValue: default(string), propertyChanged: MainButtonTextPropertyChanged);

        private static void MainButtonTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ( newValue == null )
                return;

            FloatingMenuButton menu = bindable as FloatingMenuButton;

            string text = newValue?.ToString();

            menu.Text.Text = text;
            menu.Text.IsVisible = !string.IsNullOrEmpty(text);
            if ( !menu.Text.IsVisible )
                menu.Button.WidthRequest = 16;
        }

        public string MainButtonText
        {
            get { return (string) GetValue(MainButtonTextProperty); }
            set { SetValue(MainButtonTextProperty, value); }
        }
        #endregion MainButtonText

        #region MainButtonIcon
        public static readonly BindableProperty MainButtonIconProperty = BindableProperty.Create(nameof(MainButtonIcon), typeof(string), typeof(FloatingMenuButton), defaultValue: default(string), propertyChanged: MainButtonIconPropertyChanged);

        private static void MainButtonIconPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            FloatingMenuButton menu = bindable as FloatingMenuButton;

            string icon = newValue?.ToString();

            menu.Icon.Text = icon;
            menu.Icon.IsVisible = !string.IsNullOrEmpty(icon);
        }

        /// <summary>
        /// Ícone do botão principal do menu flutuante.
        /// Utilize a classe Icones com a referência do ícone desejado. Exemplo: Icones.FAPlus
        /// Lembre-se de referenciar a classe Icones no cabeçalho do XAML.
        /// </summary>
        public string MainButtonIcon
        {
            get { return (string) GetValue(MainButtonIconProperty); }
            set { SetValue(MainButtonIconProperty, value); }
        }
        #endregion MainButtonIcon

        #region MainButtonBackgroundColor
        public static readonly BindableProperty MainButtonBackgroundColorProperty = BindableProperty.Create(nameof(MainButtonBackgroundColor), typeof(Color), typeof(FloatingMenuButton), (Color) Color.Black);
        public Color MainButtonBackgroundColor
        {
            get { return (Color) GetValue(MainButtonBackgroundColorProperty); }
            set { SetValue(MainButtonBackgroundColorProperty, value); }
        }
        #endregion MainButtonForegroundColor

        #region MainButtonBackgroundColor
        public static readonly BindableProperty MainButtonForegroundColorProperty = BindableProperty.Create(nameof(MainButtonForegroundColor), typeof(Color), typeof(FloatingMenuButton), Color.White);
        public Color MainButtonForegroundColor
        {
            get { return (Color) GetValue(MainButtonForegroundColorProperty); }
            set { SetValue(MainButtonForegroundColorProperty, value); }
        }
        #endregion MainButtonForegroundColor

        #region Command
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(FloatingMenuButton), defaultValue: null, propertyChanged: CommandPropertyChanged);

        private static void CommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            FloatingMenuButton menu = bindable as FloatingMenuButton;

            menu.Button.GestureRecognizers.Clear();

            ICommand Command = (ICommand) newValue;

            menu.Button.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    if ( Command != null )
                        if ( Command.CanExecute(null) )
                            Command.Execute(null);   
                })
            });
        }

        public ICommand Command
        {
            get { return (ICommand) GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        #endregion Command
    }
}