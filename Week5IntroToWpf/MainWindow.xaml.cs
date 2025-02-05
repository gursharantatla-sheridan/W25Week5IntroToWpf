using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week5IntroToWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            //var result = MessageBox.Show("Hello world", "Message", MessageBoxButton.YesNo, MessageBoxImage.Information);

            //if (result == MessageBoxResult.Yes)
            //    MessageBox.Show("YES button clicked");
            //else
            //    MessageBox.Show("NO button clicked");


            string name = txtName.Text;
            MessageBox.Show("Hello " + name);
        }

        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtName.Background = Brushes.LightBlue;
        }

        private void txtName_LostFocus(object sender, RoutedEventArgs e)
        {
            txtName.Background = Brushes.White;
        }
    }
}