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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        
        private void OnCalculeteClick(object sender, RoutedEventArgs e)
        {
            bool width = !double.TryParse(WidthTextBox.Text,out double widthvalue) || widthvalue <= 0;
            bool height = !double.TryParse(HeighTextBox.Text, out double heightvalue) || heightvalue <= 0;

            if (width || height) {
                CalculateText.Visibility = Visibility.Hidden;

                label1.Foreground = Brushes.Red;
                label2.Foreground = Brushes.Red;
                ErrorText.Visibility = Visibility.Visible;
            }
            else
            {
                label1.Foreground = Brushes.Black;
                label2.Foreground = Brushes.Black;
                ErrorText.Visibility = Visibility.Hidden;

                double sum = widthvalue * heightvalue;
                CalculateText.Visibility = Visibility.Visible;
                CalculateText.Content = sum;
            }
        }
    }
}