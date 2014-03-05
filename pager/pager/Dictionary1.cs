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


namespace pager
{
    partial class Dictionary1
    {
        private void mouse_enter(object sender, RoutedEventArgs e)
        {
            Button myBorder = sender as Button;// myBorder is a Instance of Border
            Brush labelDark = myBorder.Background;
            Colorpicker colorPicker = new Colorpicker(labelDark);// Creating Objet Of ColorPicker
            myBorder.Background = colorPicker.dark();
            // ((Button)sender).Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            //((Button)sender).Background = new SolidColorBrush(Color.FromRgb(200,200,200));
        }
        private void mouse_leave(object sender, RoutedEventArgs e)
        {
            Button myBorder = sender as Button;// myBorder is a Instance of Border
            Brush labelDark = myBorder.Background;
            Colorpicker colorPicker = new Colorpicker(labelDark);// Creating Objet Of ColorPicker
            myBorder.Background = colorPicker.light();
            Console.WriteLine("fuckhh");
            // ((Button)sender).Background = new SolidColorBrush(Color.FromRgb(51,51,51));
            // ((Button)sender).Foreground = new SolidColorBrush(Color.FromRgb(170,170,170));
        }
        private void mouse_leftdown(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Left");
            Button myBorder = sender as Button;// myBorder is a Instance of Border
            Brush labelDark = myBorder.Background;
            Colorpicker colorPicker = new Colorpicker(labelDark);// Creating Objet Of ColorPicker
            myBorder.Background = colorPicker.darker();
            //((Button)sender).Background = new SolidColorBrush(Color.FromRgb(10,10,10));
            // ((Button)sender).Foreground = new SolidColorBrush(Color.FromRgb(0,0,0));
        }
        private void mouse_leftup(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Up");
            Button myBorder = sender as Button;// myBorder is a Instance of Border
            Brush labelDark = myBorder.Background;
            Colorpicker colorPicker = new Colorpicker(labelDark);// Creating Objet Of ColorPicker
            myBorder.Background = colorPicker.lighter();
            //((Button)sender).Background = new SolidColorBrush(Color.FromRgb(51,51,51));
        }
    }
}
