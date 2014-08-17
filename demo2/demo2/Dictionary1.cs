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
namespace demo2
{
    partial class Dictionary1
    {
        DropShadowBitmapEffect myDropShadowEffect = new DropShadowBitmapEffect();
        public Dictionary1()
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
            ((PasswordBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(77, 169, 77));
            // Apply the bitmap effect to the Border.
            ((PasswordBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Success End Here
        private void gotFocusPrimary(object sender, RoutedEventArgs e)
        {
            ((PasswordBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(51, 124, 187));
            // Apply the bitmap effect to the Border.
            ((PasswordBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Primary End Here
        private void gotFocusDanger(object sender, RoutedEventArgs e)
        {
            ((PasswordBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(202, 68, 64));

            // Apply the bitmap effect to the Border.
            ((PasswordBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Danger End Here
        private void gotFocusWarning(object sender, RoutedEventArgs e)
        {
            ((PasswordBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(225, 158, 63));

            // Apply the bitmap effect to the Border.
            ((PasswordBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Warning End Here
        private void gotFocusDefault(object sender, RoutedEventArgs e)
        {
            ((PasswordBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(75, 75, 75));

            // Apply the bitmap effect to the Border.
            ((PasswordBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Warning End Here
        private void lostFocus(object sender, RoutedEventArgs e)
        {
            ((PasswordBox)sender).BitmapEffect = null;
        }//Method For Focus End Here
        private void BorderLoaded(object sender, RoutedEventArgs e)
        {
            Border border = sender as Border;
            Border ChildBorder = border.FindName("childborder") as Border;
            //Setting border to Width of parent border..
            ChildBorder.Width = (border.Width * 90) / 100;
            ChildBorder.Height = (border.Height * 6) / 100;
        }//loaded event of border end here
        private void animatedBorderLoaded(object sender, RoutedEventArgs e)
        {
            Border border = sender as Border;
            Colorpicker colorPicker = new Colorpicker(border.Background);
            if (colorPicker.b <= 15 && colorPicker.g <= 15 && colorPicker.r <= 15)
            {
                border.Background = colorPicker.lighter();
            }
            else
            {
                border.Background = colorPicker.dark();
            }


        }//Progress Bar
        private void gotFocusSuccessText(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(77, 169, 77));
            // Apply the bitmap effect to the Border.
            ((TextBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Success End Here
        private void gotFocusPrimaryText(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(102, 175, 233));
            // Apply the bitmap effect to the Border.
            ((TextBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Primary End Here
        private void gotFocusDangerText(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(202, 68, 64));

            // Apply the bitmap effect to the Border.
            ((TextBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Danger End Here
        private void gotFocusWarningText(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(225, 158, 63));

            // Apply the bitmap effect to the Border.
            ((TextBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Warning End Here
        private void gotFocusDefaultText(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BorderBrush = new SolidColorBrush(Color.FromRgb(75, 75, 75));

            // Apply the bitmap effect to the Border.
            ((TextBox)sender).BitmapEffect = myDropShadowEffect;

        }//Method For Focus of Warning End Here
        private void lostFocusText(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).BitmapEffect = null;
        }//Method For Focus End Here
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
            myBorder.Background = colorPicker.light();
            //((Button)sender).Background = new SolidColorBrush(Color.FromRgb(51,51,51));
        }
        private void new_click(object sender, RoutedEventArgs e)
        {

        }
        private void save_click(object sender, RoutedEventArgs e)
        {

        }
        private void open_click(object sender, RoutedEventArgs e)
        {

        }
        private void exit_click(object sender, RoutedEventArgs e)
        {

        }
        private void bold_click(object sender, RoutedEventArgs e)
        {

        }
        private void italic_click(object sender, RoutedEventArgs e)
        {

        }
        private void cut_click(object sender, RoutedEventArgs e)
        {

        }
        private void copy_click(object sender, RoutedEventArgs e)
        {

        }
        private void paste_click(object sender, RoutedEventArgs e)
        {

        }
        private void color_click(object sender, RoutedEventArgs e)
        {

        }
        private void mousedownScrollbar(object sender, RoutedEventArgs e)
        {
            ((ScrollViewer)sender).Foreground = Brushes.Black;
        }
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
    class CustomPanel : Grid
    {
        public CustomPanel()
            : base()
        {
            Style style = Application.Current.FindResource("panel") as Style;
            this.Style = style;

        }
    }
    class Title : Label
    {
        public Title()
        {

            Type = "headingPanelInfo";



            this.Loaded += Title_Loaded;
        }

        String _Type;
        public String Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private void Title_Loaded(object sender, RoutedEventArgs e)
        {

            Style headingPanel = Application.Current.FindResource(Type) as Style;
            this.Style = headingPanel;
            this.VerticalAlignment = VerticalAlignment.Top;

        }
    }
    class Body : Grid
    {
        public Body()
        {
            this.Loaded += Body_Loaded;
            this.Margin = new Thickness(0, 8, 0, 0);


        }
        private void Body_Loaded(object sender, RoutedEventArgs e)
        {

            Border border = new Border();
            //border.VerticalAlignment = VerticalAlignment.Bottom;

            border.Padding = new Thickness(8);
            Style borderStyle = Application.Current.FindResource("textPanelBorder") as Style;
            border.Style = borderStyle;
            CustomPanel panel = this.Parent as CustomPanel;

            try
            {
                panel.Children.Remove(this);
                border.Child = this;
                panel.Children.Add(border);
            }
            catch (Exception)
            {
                /*Do nothing */
            }
        }
    }
    class CustomProgressBar : ProgressBar
    {

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(Double), typeof(CustomProgressBar), new PropertyMetadata(new PropertyChangedCallback(OnValueChanged)));
        public static readonly DependencyProperty RangeProperty = DependencyProperty.Register("Range", typeof(Double), typeof(CustomProgressBar), new PropertyMetadata((Double)100));
        public static readonly DependencyProperty widthValueProperty = DependencyProperty.Register("widthValue", typeof(Double), typeof(CustomProgressBar), new PropertyMetadata(default(Double)));
        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register("Type", typeof(String), typeof(CustomProgressBar), new PropertyMetadata("progressBarInfo", new PropertyChangedCallback(OnTypeChanged)));
        // public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(String), typeof(CustomProgressBar), new PropertyMetadata(null));

        public CustomProgressBar()
        {



            this.Style = Application.Current.FindResource(Type) as Style;



        }







        public static void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

            CustomProgressBar progress = sender as CustomProgressBar;
            TextBlock textblock = new TextBlock();
            Canvas canvas = new Canvas();
            canvas.HorizontalAlignment = HorizontalAlignment.Center;
            canvas.VerticalAlignment = VerticalAlignment.Center;
            canvas.Children.Add(textblock);
            try
            {
                Grid grid2 = (Grid)progress.Template.FindName("grid", progress);
                grid2.Children.Add(canvas);
            }
            catch (Exception)
            {
            }

            //Border progressValue = progress.FindName("progressValue") as Border;

            progress.widthValue = (((progress.Value * 100) / progress.Range) * progress.Width) / 100;
            textblock.Text = progress.Value + "";
            Console.WriteLine(textblock.Text);



        }



        public static void OnTypeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            CustomProgressBar progress = sender as CustomProgressBar;
            progress.Style = Application.Current.FindResource(progress.Type) as Style;
        }


        public Double widthValue
        {
            get { return (Double)GetValue(widthValueProperty); }
            set { SetValue(widthValueProperty, value); }
        }



        public String Type
        {
            get { return (String)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }


        /* public String Text
         {
             get { return (String)GetValue(TextProperty); }
             set { SetValue(TextProperty, value); }
         }*/




        public Double Value
        {
            get { return (Double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public Double Range
        {
            get { return (Double)GetValue(RangeProperty); }
            set { SetValue(RangeProperty, value); }
        }


    }
}
