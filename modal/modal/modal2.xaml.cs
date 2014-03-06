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

namespace modal
{
    /// <summary>
    /// Interaction logic for modal.xaml
    /// </summary>
    public partial class modal2 : Window
    {
        public modal2()
        {
            InitializeComponent();
        }
        private void mouseleftbuttondownModal(object sender, RoutedEventArgs e)
        {
            if (this.border.IsMouseOver == false)
                this.Close();
        }
    }
}
