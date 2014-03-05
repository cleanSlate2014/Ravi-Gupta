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

namespace label
{
    partial class Dictionary1
    {
       
        private void mouseenterLabel(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Enter");
            Label mylabel = sender as Label;// myBorder is a Instance of Border
            Brush labelDark = new SolidColorBrush();// Creating Object Of Brush
            labelDark = mylabel.Background;
            Colorpicker colorPicker = new Colorpicker(labelDark);// Creating Objet Of ColorPicker
            mylabel.Background = colorPicker.dark();
            
        }//Label Mouse Enter Event End Here



        private void mouseleaveLabel(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Exit");
            Label mylabel = sender as Label;
            Brush labelLight = new SolidColorBrush();
            labelLight = mylabel.Background;
            Colorpicker colorPicker = new Colorpicker(labelLight);
            mylabel.Background = colorPicker.light();
        }//Label Mouse Leave Event End Here
       
    }



}
