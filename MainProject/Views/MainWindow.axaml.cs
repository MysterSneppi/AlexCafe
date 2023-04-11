using Avalonia.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MainProject.Views
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        #region Views
        MainPageView mainPageView { get; set; }
        SettingsPageView settingsPageView { get; set; }
        StatisticsPageView statisticsPageView { get; set; }
        OrderPageView orderPageView { get; set; }
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            mainPageView = new MainPageView();
            settingsPageView = new SettingsPageView();
            statisticsPageView = new StatisticsPageView();
            orderPageView = new OrderPageView();
           
            this.DataContext = this;
        }

        public void ChangedSelect(object sender, SelectionChangedEventArgs e)
        {
            switch (((TabControl)sender).SelectedIndex)
            {
                case 0:
                    CurrentView = mainPageView;
                    break;
                case 1:
                    CurrentView = settingsPageView;
                    break;
                case 2:
                    CurrentView = statisticsPageView;
                    break;
                case 3:
                    CurrentView = orderPageView;
                    break;
            }
        }

        private object _сurrentView;

        public object CurrentView
        {
            get => _сurrentView;
            set
            {
                if (_сurrentView != value)
                {
                    _сurrentView = value;
                    OnPropertyChanged(nameof(CurrentView));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }

}

