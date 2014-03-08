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

namespace tabcontrol
{
    partial class Dictionary1
    {
        
        private void mouse_leftdown(object sender, RoutedEventArgs e)
        {
            Colorpicker colorPicker;
            TabItem myTabitem = sender as TabItem;// myBorder is a Instance of Border
            if (myTabitem.IsSelected == false)
            {
                TabPanel tabPanel = VisualTreeHelper.GetParent(myTabitem) as TabPanel;
                //Console.WriteLine( tabPanel.Children.Count );
                for (int i = 0; i < tabPanel.Children.Count; i++)
                {
                   TabItem tabItem = tabPanel.Children[i] as TabItem;
                   if (tabItem.IsSelected == true)
                   {
                       colorPicker = new Colorpicker(tabItem.Background);
                       tabItem.Background = colorPicker.lighter();
                       myTabitem.IsSelected = false;
                   }
                }
                colorPicker = new Colorpicker(myTabitem.Background);
                myTabitem.Background = colorPicker.darker();
                myTabitem.IsSelected = true;
                
            }
         
          
        }//mouse left down button for tabcontrol end here

        private void MyBorderLoad(object sender, RoutedEventArgs e)
        {
            Border border = sender as Border;
            Colorpicker colorPicker = new Colorpicker(border.Background);
            border.BorderBrush = colorPicker.darker();
        }//loaded event of border end here


        private void TabItemLoaded(object sender, RoutedEventArgs e)
        {
            Colorpicker colorPicker;
            TabItem tabItem = sender as TabItem;
            if (tabItem.IsSelected)
            {
              colorPicker   = new Colorpicker(tabItem.Background);
              tabItem.Background = colorPicker.darker();

            }
        }//loaded event of tabitem end here

    }
}
