using System.Windows;
using RedisManage.WindowView;

namespace RedisManage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnServerManage_OnClick(object sender, RoutedEventArgs e)
        {
            var serverManage = new ServerManage();
            serverManage.ShowDialog();
        }
    }
}