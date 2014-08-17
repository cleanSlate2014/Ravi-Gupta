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

namespace Demo
{
    partial class Dictionary1
    {
        private void loaded(object sender, RoutedEventArgs e)
        {
            #region Canvas Close
            var canvasClose = new Canvas
            {
                Clip = Geometry.Parse("F1 M 0,0L 76,0L 76,76L 0,76L 0,0"),
                Margin = new Thickness(1350, 20, -252, 302)
            };

            var pathClose = new Path
            {
                Width = 10,
                Height = 10,
                Fill = new SolidColorBrush(Colors.Black),
                Stretch = Stretch.Fill,
                Data = Geometry.Parse("F1 M 26.9166,22.1667L 37.9999,33.25L 49.0832,22.1668L 53.8332,26.9168L 42.7499,38L 53.8332,49.0834L 49.0833,53.8334L 37.9999,42.75L 26.9166,53.8334L 22.1666,49.0833L 33.25,38L 22.1667,26.9167L 26.9166,22.1667 Z")
            };
            canvasClose.Children.Add(pathClose);
            Canvas.SetTop(pathClose, 0);
            Canvas.SetLeft(pathClose, 0);
            #endregion
            #region Canvas Minimize
            var canvasMinimize = new Canvas
            {
                Clip = Geometry.Parse("F1 M 0,0L 76,0L 76,76L 0,76L 0,0"),
                Margin = new Thickness(1310, 24, -211, 302)
            };

            var pathMinimize = new Path
            {
                Width = 10,
                Height = 3,
                Fill = new SolidColorBrush(Colors.Black),
                Stretch = Stretch.Fill,
                Data = Geometry.Parse("F1 M 19,38L 57,38L 57,44L 19,44L 19,38 Z")
            };
            canvasMinimize.Children.Add(pathMinimize);
            // Canvas.SetTop(pathMinimize, 0);
            Canvas.SetLeft(pathMinimize, 0);
            #endregion
            #region Canvas Maximize
            var canvasMaximize = new Canvas
            {
                Clip = Geometry.Parse("F1 M 0,0L 76,0L 76,76L 0,76L 0,0"),
                Margin = new Thickness(1330, 19, -231, 302)
            };

            var pathMaximize = new Path
            {
                Width = 8,
                Height = 8,
                Fill = new SolidColorBrush(Colors.Black),
                Stretch = Stretch.Fill,
                Data = Geometry.Parse("F1 M 18,23L 58,23L 58,53L 18,53L 18,23 Z M 54,31L 22,31L 22,49L 54,49L 54,31 Z")
            };
            canvasMaximize.Children.Add(pathMaximize);
            Canvas.SetTop(pathMaximize, 3);
            Canvas.SetLeft(pathMaximize, 0);
            #endregion
            //pathClose.PreviewMouseLeftButtonUp+=pathClose_PreviewMouseLeftButtonUp;

            MainWindow mainwindow = sender as MainWindow;
            mainwindow.grid.Children.Add(canvasClose);
            mainwindow.grid.Children.Add(canvasMinimize);
            mainwindow.grid.Children.Add(canvasMaximize);


        }
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
        private void BorderLoaded(object sender, RoutedEventArgs e)
        {
            Border border = sender as Border;
            Border ChildBorder = border.FindName("childborder") as Border;
            //Setting border to Width of parent border..
            ChildBorder.Width = (border.Width * 90) / 100;
            ChildBorder.Height = (border.Height * 6) / 100;
        }//loaded event of border end here
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
        private void mouse_enter(object sender, RoutedEventArgs e)
        {
            Button myBorder = sender as Button;// myBorder is a Instance of Border
            Brush labelDark = myBorder.Background;
            Colorpicker colorPicker = new Colorpicker(labelDark);// Creating Objet Of ColorPicker
            myBorder.Background = colorPicker.dark();
            // ((Button)sender).Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            //((Button)sender).Background = new SolidColorBrush(Color.FromRgb(200,200,200));
        }//Pager
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
        }//Pager
       
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
        public void addBreadcrumbs(List<string> newlist)
        {
            string[] newLabel = newlist.ToArray();
            for (int j = 0; j < newLabel.Length; j++)
            {
                lab = new Label();
                lab.PreviewMouseLeftButtonDown += lab_PreviewMouseLeftButtonDown;
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


        public void addBreadcrumbs(List<string> newList, string newString)
        {
            newList.Add(newString);
            string[] newLabel = newList.ToArray();
            Console.Write(newLabel.Length);
            for (int j = 0; j < newLabel.Length; j++)
            {
                lab = new Label();
                lab.PreviewMouseLeftButtonDown += lab_PreviewMouseLeftButtonDown;
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


    class Childcrumbs : Grid
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
            lab.Foreground = new SolidColorBrush(Color.FromRgb(55, 55, 55));

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
