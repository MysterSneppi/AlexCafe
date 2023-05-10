using MainProject.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MainProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        #region Views
        MainPageView mainPageView { get; set; }
        SettingsPageView settingsPageView { get; set; }
        StatisticsPageView statisticsPageView { get; set; }
        OrderPageView orderPageView { get; set; }
        #endregion

        public MainWindowViewModel()
        {
            mainPageView = new MainPageView();
            settingsPageView = new SettingsPageView();
            statisticsPageView = new StatisticsPageView();
            orderPageView = new OrderPageView();
        }

        private object _ñurrentView;
        public object CurrentView
        {
            get => _ñurrentView;
            set
            {
                if (_ñurrentView != value)
                {
                    _ñurrentView = value;
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


