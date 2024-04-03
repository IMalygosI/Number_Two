using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Number_Two
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Next.Click += Click_Next;
        }

        public void Click_Next(object sender, RoutedEventArgs args)
        {
            Window1 taskWindow = new Window1();
            taskWindow.Show();
        }
    }
}