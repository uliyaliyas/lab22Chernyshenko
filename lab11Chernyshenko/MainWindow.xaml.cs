using lab11Chernyshenko.lab2;
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

namespace lab11Chernyshenko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bubble bubble;
        private Choice choice;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bubble = new Bubble(int.Parse(FirstSize.Text));
            choice = new Choice(int.Parse(FirstSize.Text));
            ResFirst.Text += bubble.Print();
            ResFirst.Text += "\n";
            ResFirst.Text += choice.Print();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (IsBubble.IsChecked == true)
            {
                ResFirst.Text += "\n";
                ResFirst.Text += bubble.Sort(choice);
            }
            else if (IsChoice.IsChecked == true)
            {
                ResFirst.Text += "\n";
                ResFirst.Text += choice.Sort(bubble);
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (IsBubble.IsChecked == true)
            {
                ResFirst.Text += "\n";
                ResFirst.Text += bubble.Foreach();
            }
            else if (IsChoice.IsChecked == true)
            {
                ResFirst.Text += "\n";
                ResFirst.Text += choice.Foreach();
            }
        }
    }
}
