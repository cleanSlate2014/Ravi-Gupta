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
using System.Timers;
using System.Resources;
using System.Windows.Media.Effects;

namespace custom_template
{
   partial class library
    {
       //TextBox
        DropShadowBitmapEffect myDropShadowEffect = new DropShadowBitmapEffect();
       //TextBox
       public library()
       {
           //TextBox
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
           //TextBox
       }

       //Progress Bar
       private void mouseenterProgressbar(object sender, MouseEventArgs e)
       {
           ((Rectangle)sender).Width++;
       }//Progress Bar End Here



       //ToolBar Event Handler Start Here
       private void mouseenterToolbar(object sender, RoutedEventArgs e)
       {
           Button myButton = sender as Button;
           Brush buttonDark = myButton.Background;
           Colorpicker colorPicker = new Colorpicker(buttonDark);// Creating Objet Of ColorPicker
           myButton.Background = colorPicker.dark();
       }//mouse enter toolbar end here



       private void mouseleaveToolbar(object sender, RoutedEventArgs e)
       {
           Button myButton = sender as Button;
           Brush buttonLight = myButton.Background;
           Colorpicker colorPicker = new Colorpicker(buttonLight);// Creating Objet Of ColorPicker
           myButton.Background = colorPicker.light();
       }//mouse leave toolbar end here



       private void previewmouseleftbuttondownToolbar(object sender, RoutedEventArgs e)
       {
           Button myButton = sender as Button;
           Brush buttonDarker = myButton.Background;
           Colorpicker colorPicker = new Colorpicker(buttonDarker);// Creating Objet Of ColorPicker
           myButton.Background = colorPicker.darker();
       }//mouse left button down end here



       private void previewmouseleftbuttonupToolbar(object sender, RoutedEventArgs e)
       {
           Button myButton = sender as Button;
           Brush buttonLighter = myButton.Background;
           Colorpicker colorPicker = new Colorpicker(buttonLighter);// Creating Objet Of ColorPicker
           myButton.Background = colorPicker.lighter();
       }// mouse left button up end here



       //ToolBar Event Handler and Here



       //TextBox Events Start Here
       private void gotFocusSuccess(object sender, RoutedEventArgs e)
       {
           ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(77, 169, 77));
           // Apply the bitmap effect to the Border.
           ((TextBox)sender).BitmapEffect = myDropShadowEffect;

       }//Method For Focus of Success End Here




       private void gotFocusPrimary(object sender, RoutedEventArgs e)
       {
           ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(51, 124, 187));
           // Apply the bitmap effect to the Border.
           ((TextBox)sender).BitmapEffect = myDropShadowEffect;

       }//Method For Focus of Primary End Here


       private void gotFocusDanger(object sender, RoutedEventArgs e)
       {
           ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(202, 68, 64));

           // Apply the bitmap effect to the Border.
           ((TextBox)sender).BitmapEffect = myDropShadowEffect;

       }//Method For Focus of Danger End Here


       private void gotFocusWarning(object sender, RoutedEventArgs e)
       {
           ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(225, 158, 63));

           // Apply the bitmap effect to the Border.
           ((TextBox)sender).BitmapEffect = myDropShadowEffect;

       }//Method For Focus of Warning End Here


       private void gotFocusDefault(object sender, RoutedEventArgs e)
       {
           ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(75, 75, 75));

           // Apply the bitmap effect to the Border.
           ((TextBox)sender).BitmapEffect = myDropShadowEffect;

       }//Method For Focus of Warning End Here



       private void lostFocus(object sender, RoutedEventArgs e)
       {
           ((TextBox)sender).BitmapEffect = null;
       }//Method For Focus End Here

       //TextBox Events End Here


       //Label Start Here
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
       //Label End Here
       
       //Badge Events Start here
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
       //Badge Events End Here

    }
}
