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
using System.Windows.Resources;


namespace breadcrumbs3
{
    partial class Dictionary1
    {
    }


    class Breadcrumbs : StackPanel 
    {
        Label lab;
        public Breadcrumbs()
        {
            Width = 700;
            Height = 30;
            Background = Brushes.White;
            this.Orientation = Orientation.Horizontal;
        }
        static int i = 0;
        public void addBreadcrumbs(List<string>  newlist)
        {
            string[] newLabel = newlist.ToArray();
            for(int j=0;j<newLabel.Length;j++)
            {
                lab = new Label();
                lab.PreviewMouseLeftButtonDown+=lab_PreviewMouseLeftButtonDown;
                lab.FontSize = 15;
                if (!(newLabel.Length - 1 == i))
                {
                    lab.Content = newLabel[j] + "  /";
                }
                else
                {
                    lab.Content = newLabel[j];

                }
                if (newLabel.Length - 1 == i)
                {
                    lab.Foreground = new SolidColorBrush(Color.FromRgb(55,55,55));

                }
                else
                {
                    lab.Foreground = new SolidColorBrush(Color.FromRgb(66,139,202));
                }
          this.Children.Add(lab);
          Console.WriteLine(lab.Content);
          i++;
            }//for loop end here
        }//addBreadcrums function end here


        public void addBreadcrumbs(List<string> newList, string newString)
        {
            newList.Add(newString);
            string[] newLabel = newList.ToArray();
            Console.Write(newLabel.Length);
            for (int j = 0; j < newLabel.Length; j++)
            {
                lab = new Label();
                lab.PreviewMouseLeftButtonDown+=lab_PreviewMouseLeftButtonDown;
                lab.FontSize = 15;
                //  labelArray[j].Content = newLabel[j];
                if (!(newLabel.Length - 1 == i))
                {
                    lab.Content = newLabel[j] + "  /";
                }
                else
                {
                    lab.Content = newLabel[j];

                }
                if (newLabel.Length - 1 == i)
                {
                    lab.Foreground = new SolidColorBrush(Color.FromRgb(55, 55, 55));

                }
                else
                {
                    lab.Foreground = new SolidColorBrush(Color.FromRgb(66, 139, 202));
                }
                this.Children.Add(lab);
                Console.WriteLine(lab.Content);
                i++;
            }//for loop end here
        }//addBreadcrums function end here

        public void lab_PreviewMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("hello");
            
        }

       
     }//class breadcrums end here


    class Childcrumbs:Grid
    {
        
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("content", typeof(String), typeof(Childcrumbs), new PropertyMetadata("No Name", LastNameChangedCallback));

        private static void LastNameChangedCallback(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            Label lab = new Label();
            Label lab2 = new Label();
            Console.WriteLine(e.OldValue + " " + e.NewValue);
            lab.Content = e.NewValue;
            Childcrumbs cc = (Childcrumbs)obj;
            lab2.Content = lab.Content + "  /";
            Console.WriteLine(lab);
            cc.Children.Add(lab2);
            lab2.FontSize = 15;
            lab2.Foreground = new SolidColorBrush(Color.FromRgb(66, 139, 202));
            
        }

        public static readonly DependencyProperty ActiveProperty = DependencyProperty.Register("activeContent", typeof(String), typeof(Childcrumbs), new PropertyMetadata("", LastNameChangedCallbackActive));

        private static void LastNameChangedCallbackActive(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            Label lab = new Label();
            Console.WriteLine(e.OldValue + " " + e.NewValue);
            lab.Content = e.NewValue;
            Childcrumbs cc = (Childcrumbs)obj;
            Console.WriteLine(lab);
            cc.Children.Add(lab);
            lab.FontSize = 15;
            lab.Foreground = new SolidColorBrush(Color.FromRgb(55,55,55));

        }
       
      /*  private static object LastNameCoerceCallback(DependencyObject obj, object o)
        {
            string s = o as string;
            if (s.Length > 8)
                s = s.Substring(0, 8);
            return s;
        }*/

       /* private static bool LastNameValidateCallback(object value)
        {
            return value != null;
        }*/

        public String content
        {
            get { return (String)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }

        }

        public String activeContent
        {
            get { return (String)GetValue(ActiveProperty); }
            set { SetValue(ActiveProperty, value); }

        }

        
        
        public Childcrumbs()
        {
           // lab.Foreground = new SolidColorBrush(Color.FromRgb(66, 139, 202));
           // lab.FontSize = 15;
            Height = 30;


        }
    
    }//child class end here
}
