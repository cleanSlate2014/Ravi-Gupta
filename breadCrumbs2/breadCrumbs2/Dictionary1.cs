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

namespace breadCrumbs2
{
    partial class Dictionary1
    {
        
       
    }
    public class Breadcrumbs: Label
    {
        public Grid grid { get; set; }
        public Breadcrumbs()
        {
           
            Label labelInstance = new Label();
            labelInstance.Height = 50;
            labelInstance.Width = 300;
            labelInstance.Foreground = Brushes.Blue;
            labelInstance.Content = "Hello World";

        }
        public class BreadcrumbsChild : FrameworkElement
        {
            public BreadcrumbsChild()
            {


            }


        }
       

    }

    
}
   