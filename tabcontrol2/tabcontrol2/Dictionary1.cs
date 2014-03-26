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
using System.Windows.Controls.Primitives;


namespace tabcontrol2
{
    partial class Dictionary1
    {
        
        private void BorderLoaded(object sender, RoutedEventArgs e)
        {
            Border border = sender as Border;
            Border ChildBorder = border.FindName("childborder") as Border;
            //Setting border to Width of parent border..
            ChildBorder.Width = (border.Width * 90) / 100;
            ChildBorder.Height = (border.Height*6) /100;
        }//loaded event of border end here


       
        
    }
}
