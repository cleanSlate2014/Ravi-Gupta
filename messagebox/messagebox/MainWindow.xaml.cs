using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace messagebox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 w = new Window1();
       // Label l = new Label();
      //  Rectangle r = new Rectangle();
        public MainWindow()
        {
            InitializeComponent();
          //  r.Fill = Brushes.Red;
           // w.rect.Children.Add(r);
            
        }

        private void clickme(object sender, RoutedEventArgs e)
        {
           
          
            w.rect.Opacity = 1;
            w.Show();
        }
    }
}
