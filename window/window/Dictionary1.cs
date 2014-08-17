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

namespace window
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
           canvasClose.PreviewMouseLeftButtonUp+=canvasClose_PreviewMouseLeftButtonUp;
           canvasMaximize.PreviewMouseLeftButtonUp+=canvasMaximize_PreviewMouseLeftButtonUp;
           canvasMinimize.PreviewMouseLeftButtonUp+=canvasMinimize_PreviewMouseLeftButtonUp;

           MainWindow mainwindow = sender as MainWindow;
           mainwindow.grid.Children.Add(canvasClose);
           mainwindow.grid.Children.Add(canvasMinimize);
           mainwindow.grid.Children.Add(canvasMaximize);

        }
       private void canvasClose_PreviewMouseLeftButtonUp(object sender, RoutedEventArgs e)
       {
           Canvas canvasClose = sender as Canvas;
           Grid grid = (Grid)canvasClose.Parent;
           MainWindow mainwindow = (MainWindow)grid.Parent;
           mainwindow.Close();
       }
       private void canvasMaximize_PreviewMouseLeftButtonUp(object sender, RoutedEventArgs e)
       {
           Canvas canvasClose = sender as Canvas;
           Grid grid = (Grid)canvasClose.Parent;
           MainWindow mainwindow = (MainWindow)grid.Parent;
           mainwindow.WindowState = WindowState.Maximized;

       }
       private void canvasMinimize_PreviewMouseLeftButtonUp(object sender, RoutedEventArgs e)
       {
           Canvas canvasClose = sender as Canvas;
           Grid grid = (Grid)canvasClose.Parent;
           MainWindow mainwindow = (MainWindow)grid.Parent;
           mainwindow.WindowState = WindowState.Minimized;
       }

        

    }
}
