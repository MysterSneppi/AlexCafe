using Avalonia;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using System.Reflection;


namespace MainProject.Views
{
    public partial class MiniDataModul : UserControl
    {

        public static readonly StyledProperty<string> ImagePathProperty = AvaloniaProperty.Register<MiniDataModul, string>(nameof(ImagePath));  
        public string ImagePath 
        {
            get { return GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty,value); }
        }

        public static readonly StyledProperty<string> NameBlockProperty = AvaloniaProperty.Register<MiniDataModul, string>(nameof(NameBlock));

        public string NameBlock
        {
            get { return GetValue(NameBlockProperty); }
            set { SetValue(NameBlockProperty, value); }
        }

        public static readonly StyledProperty<string> NumberBlockProperty = AvaloniaProperty.Register<MiniDataModul, string>(nameof(NumberBlock));

        public string NumberBlock
        {
            get { return GetValue(NumberBlockProperty); }
            set { SetValue(NumberBlockProperty, value); }
        }

        public MiniDataModul()
        {
            InitializeComponent();
            
            this.DataContext = this;
        }
    }
}
