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
using System.Data.Linq;

namespace ProjectEndOfYear
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        S00167749Entities2 db = new S00167749Entities2();
        public MainWindow()
        {
            InitializeComponent();
            var query = from c in db.StaffTBLs
                        where c.Year == 1
                        select c;

            listboxDetails.ItemsSource = query.ToList();
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }


    //public class Test1
    //{

    //}

    //interface Test2
    //{

    //}

    //public class Test3:Test1, Test2
    //{

    //}
}


