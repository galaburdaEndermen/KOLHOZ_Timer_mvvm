using System.Windows;

namespace GAS_timer_mvvm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VievModels.MainVievModel();
            this.Width = (DataContext as VievModels.MainVievModel).Timers.Count * 225 + 70;
        }
    }
}
