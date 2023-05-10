using System;
using System.Windows;
using MessageBox = System.Windows.MessageBox;
using RoutedEventArgs = Avalonia.Interactivity.RoutedEventArgs;
using UserControl = Avalonia.Controls.UserControl;

namespace MainProject.Views
{
    public partial class SettingsPageView : UserControl
    {
        public SettingsPageView()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Ви точно хочете вийти з облікового запису?");
            if (a == MessageBoxResult.OK)
            {
                Environment.Exit(0);
            }
        }
    }
}
