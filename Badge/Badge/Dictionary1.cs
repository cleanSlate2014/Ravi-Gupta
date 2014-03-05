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

namespace Badge
{
    partial class Dictionary1
    {
        private void mouseenterBadge(object sender, RoutedEventArgs e)
        {
           
            Label mybadge = sender as Label;// myBorder is a Instance of Border
            Brush badgeDark = new SolidColorBrush();// Creating Object Of Brush
            badgeDark = mybadge.Background;
            Colorpicker colorPicker = new Colorpicker(badgeDark);// Creating Objet Of ColorPicker
            mybadge.Background = colorPicker.dark();

        }//Badge Mouse Enter Event End Here



        private void mouseleaveBadge(object sender, RoutedEventArgs e)
        {
           
            Label mybadge = sender as Label;
            Brush badgeLight = new SolidColorBrush();
            badgeLight = mybadge.Background;
            Colorpicker colorPicker = new Colorpicker(badgeLight);
            mybadge.Background = colorPicker.light();
        }//Badge Mouse Leave Event End Here

        
    }
}
