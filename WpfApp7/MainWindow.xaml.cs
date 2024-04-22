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

namespace WpfApp7
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
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            button.IsEnabled = !string.IsNullOrWhiteSpace(textBox.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            listBox.Items.Add(text);
            textBox.Text = "";
            DateTime time = DateTime.Now;
            string timeString = time.ToString("HH:mm:ss");
            label.Content = timeString;
        }
    }
}