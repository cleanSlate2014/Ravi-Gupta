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

namespace breadcrumbs
{
   partial class Dictionary1
    {
       public void addBreadcrumbs(object sender,string[] locations)
       {
           int counter=0;
           Label label = sender as Label;
           for (int i = 0; i < locations.Length; i++)
           {
               //Recursion
               label.Content += locations[i];
               counter++;
               if (counter != locations.Length)
               {
                   label.Content += "  -  ";
                   
               }
               
           }
           
       }
       public void addBreadcrumbs(object sender,string[] locations,string toBeAdd)
       {
           string[] crumbs = { "Home", "Profile", "Settings", "Account", "Edit", "Picture",toBeAdd};
           addBreadcrumbs(sender, crumbs);
       }

       public void active(string activeElement, object sender)
       {
           Label lab = new Label();
           lab.Content = activeElement;
          
       }
    }
}
