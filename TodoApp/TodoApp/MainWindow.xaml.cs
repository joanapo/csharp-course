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

namespace TodoApp
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

        private void AddToDoButton_CLick(object sender, RoutedEventArgs e)
        {
            string toDoText = ToDoInput.Text;
            
            if(!string.IsNullOrEmpty(toDoText))
            {
                TextBlock toDoItem = new TextBlock
                {
                    Text = toDoText,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White),
                };
                
                ToDoList.Children.Add(toDoItem);

                ToDoInput.Clear();
            }
        }
    }
}