using System.Windows;
using ClientXMessanger.ViewModels;

namespace ClientXMessanger.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            #region Init

            InitializeComponent();
            
            #endregion

            // Подключения источника данных
            this.DataContext = new MainWindowViewModel(this);
        }
    }
}
