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

namespace breadcrumbs3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Breadcrumbs b = new Breadcrumbs();
            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Account");
            list.Add("Setting");
            list.Add("Profile");
            list.Add("Change Password");
            b.addBreadcrumbs(list);
         //   b.addBreadcrumbs(list, "Change Username");
            gridy.Children.Add(b);
            
       
            
            
        }
    }

    
    
}
