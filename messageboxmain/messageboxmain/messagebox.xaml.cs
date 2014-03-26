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
using System.Windows.Shapes;
using System.ComponentModel;

namespace messageboxmain
{
    /// <summary>
    /// Interaction logic for messagebox.xaml
    /// </summary>
    /// 
    
    public partial class messagebox : Window
    {
       static messagebox mb1 = new messagebox();
       static Grid gr = new Grid();
       
        
        
        public messagebox()
        {
            InitializeComponent();
            
        }
        public static void SHOW(string body)
        {
            
            mb1.AddChild(gr);
            TextBlock tb = new TextBlock();
            gr.Children.Add(tb);
            tb.Text = body;
            Console.WriteLine("SHOW is WOrking");
            gr.Background = Brushes.Black;
            gr.Height = 200;
            gr.Width = 200;
            
        }
        private void move(object sender, RoutedEventArgs e)
        {
            DragMove();
            
        }
        
    }
}
