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

namespace progressBar
{
    partial class Dictionary1
    {
       

        public Dictionary1()
        {

        }

     

        private void mouseenterProgressbar(object sender, MouseEventArgs e)
        {
            ((Border)sender).Width++;
        }//Progress Bar End Here


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
            

        }



    }

    class CustomProgressBar : ProgressBar
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(Double), typeof(CustomProgressBar), new PropertyMetadata( new PropertyChangedCallback(OnValueChanged) ) );
        public static readonly DependencyProperty RangeProperty = DependencyProperty.Register("Range", typeof(Double), typeof(CustomProgressBar), new PropertyMetadata((Double)100));
        public static readonly DependencyProperty widthValueProperty = DependencyProperty.Register("widthValue", typeof(Double), typeof(CustomProgressBar), new PropertyMetadata(default(Double)));
        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register("Type", typeof(String), typeof(CustomProgressBar), new PropertyMetadata("progressbarInfo", new PropertyChangedCallback(OnTypeChanged) ));

        public CustomProgressBar() 
        {

            
           
                this.Style = Application.Current.FindResource(Type) as Style;
               
           
            
        }

       



       

        public static void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            
            CustomProgressBar progress = sender as CustomProgressBar;
            
            //Border progressValue = progress.FindName("progressValue") as Border;

            progress.widthValue = (((progress.Value * 100) / progress.Range) * progress.Width) / 100;
           

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
