﻿using System;
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

namespace demo2
{
    /// <summary>
    /// Interaction logic for modal2.xaml
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
