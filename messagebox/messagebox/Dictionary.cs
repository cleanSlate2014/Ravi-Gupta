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
using System.Windows.Media.Effects;

namespace messagebox
{
    partial class Dictionary
    {
        DropShadowBitmapEffect myDropShadowEffect = new DropShadowBitmapEffect();
       
        public Dictionary()
        {

            Color myShadowColor = new Color();
            myShadowColor.ScA = 1;
            myShadowColor.ScB = 2;
            myShadowColor.ScG = 0;
            myShadowColor.ScR = 0;
            myDropShadowEffect.Color = myShadowColor;

            // Set the direction of where the shadow is cast to 360 degrees.
            myDropShadowEffect.Direction = 360;

            // Set the depth of the shadow being cast.
            myDropShadowEffect.ShadowDepth = 2;

            // Set the shadow softness to the maximum (range of 0-1).
            myDropShadowEffect.Softness = 1;
            // Set the shadow opacity to half opaque or in other words - half transparent.
            // The range is 0-1.
            myDropShadowEffect.Opacity = 0.3;
        }


      
         private void gotFocusSuccess(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BorderBrush=new SolidColorBrush(Color.FromRgb(77,169,77));
           // Apply the bitmap effect to the Border.
           ((TextBox)sender).BitmapEffect = myDropShadowEffect; 

         }//Method For Focus of Success End Here



      
         private void gotFocusPrimary(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(51,124,187));
            // Apply the bitmap effect to the Border.
            ((TextBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Primary End Here


         private void gotFocusDanger(object sender, RoutedEventArgs e)
         {
             ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(202,68,64));
          
             // Apply the bitmap effect to the Border.
             ((TextBox)sender).BitmapEffect = myDropShadowEffect;

         }//Method For Focus of Danger End Here


         private void gotFocusWarning(object sender, RoutedEventArgs e)
         {
             ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(225,158,63));

             // Apply the bitmap effect to the Border.
             ((TextBox)sender).BitmapEffect = myDropShadowEffect;

         }//Method For Focus of Warning End Here


         private void gotFocusDefault(object sender, RoutedEventArgs e)
         {
             ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(75,75,75));

             // Apply the bitmap effect to the Border.
             ((TextBox)sender).BitmapEffect = myDropShadowEffect;

         }//Method For Focus of Warning End Here



        private void lostFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BitmapEffect = null;
        }//Method For Focus End Here




        private void ButtonDown(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ButtonDown");
            Button myButton = sender as Button;
            Brush buttonDark = myButton.Background;
            Colorpicker colorPicker = new Colorpicker(buttonDark);
            myButton.Background = colorPicker.darker();

        }//Button Down method ends here


        private void ButtonUp(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button Up");

            Button myButton = sender as Button;
            Brush buttonDark = myButton.Background;
            Colorpicker colorPicker = new Colorpicker(buttonDark);
            myButton.Background = colorPicker.lighter();

        }//ButtonUp method ends here


        private void ButtonLeave(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ButtonLeave");
            Button myButton = sender as Button;
            Brush buttonDark = myButton.Background;
            Colorpicker colorPicker = new Colorpicker(buttonDark);
            myButton.Background = colorPicker.light();
        }


        private void ButtonEnter(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ButtonEnter");
            Button myButton = sender as Button;
            Brush buttonDark = myButton.Background;
            Colorpicker colorPicker = new Colorpicker(buttonDark);
            myButton.Background = colorPicker.dark();
        }




    }
    
}
