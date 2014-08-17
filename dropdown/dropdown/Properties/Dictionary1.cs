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

namespace dropdown
{
    partial class Dictionary1
    {
       /* private void loaded(object sender, RoutedEventArgs e)
        {
            //ControlTemplate ct = this.myCombo.Template;
            Popup popup = sender as Popup;
            //Popup pop = ct.FindName("PART_Popup", this.myCombo) as Popup;
            popup.Placement = PlacementMode.Top;
        }*/
        private void mousedownScrollbar(object sender, RoutedEventArgs e)
        {
            ((ScrollViewer)sender).Foreground = Brushes.Black;
        }
        
    }
}
