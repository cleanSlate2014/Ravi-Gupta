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

namespace listViewcustomize
{
   partial class Dictionary1
    {
            private void mouseenter(object sender, RoutedEventArgs e)
           {
           
               ListViewItem listviewitem = sender as ListViewItem;
               listviewitem.Background = Brushes.Blue;
           }
          private void mouseleave(object sender, RoutedEventArgs e)
           {
               ListViewItem listviewitem = sender as ListViewItem;
               listviewitem.Background = Brushes.Red;
           }
         /* private void selected(object sender, RoutedEventArgs e)
       {

           ListViewItem listviewitem = sender as ListViewItem;
           listviewitem.Background = Brushes.Black;
       }
       private void unselected(object sender, RoutedEventArgs e)
       {
           ListViewItem listviewitem = sender as ListViewItem;
           listviewitem.Background = Brushes.White;
       }
       
       

        private void gotfocus(object sender, RoutedEventArgs e)
       {

           ListViewItem listviewitem = sender as ListViewItem;
           listviewitem.Background = Brushes.Red;
       }
       private void lostfocus(object sender, RoutedEventArgs e)
       {
           ListViewItem listviewitem = sender as ListViewItem;
           listviewitem.Background = Brushes.Yellow;
       }
       private void previewmouseleftbuttondown(object sender, RoutedEventArgs e)
       {
           ListViewItem listviewitem = sender as ListViewItem;
           listviewitem.Background = Brushes.Black;
       }   */

       private void mousemove(object sender, RoutedEventArgs e)
       {
           ListViewItem listviewitem = sender as ListViewItem;
           listviewitem.Background = Brushes.Black;
          
       }
       private void mousedownScrollbar(object sender, RoutedEventArgs e)
       {
           ((ScrollViewer)sender).Foreground = Brushes.Black;
       }
    }
}
