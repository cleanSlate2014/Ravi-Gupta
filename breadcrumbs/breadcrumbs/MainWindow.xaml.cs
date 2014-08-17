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

namespace breadcrumbs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Label label = new Label();
        public MainWindow()
        {
            InitializeComponent();
            
            label.Content = "hello";
            label.Background = Brushes.Red;
            label.Foreground = Brushes.Blue;
            label.Height = 300;
            label.Width = 300;
            this.grid.Children.Add(label);
            label.Loaded += label_Loaded;
            
            
            
        }

        void label_Loaded(object sender, RoutedEventArgs e)
        {
            string[] crumbs = { "Home", "Profile", "Settings", "Account", "Edit", "Picture" };
            Dictionary1 ds = new Dictionary1();
            ds.addBreadcrumbs(sender, crumbs, "Duniya");
            ds.active(crumbs[3], sender);
            
        }


        
    }
}
