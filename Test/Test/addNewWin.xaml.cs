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
using static Test.MainWindow;

namespace Test
{
    /// <summary>
    /// Interakční logika pro addNewWin.xaml
    /// </summary>
    public partial class addNewWin : Window
    {
        public string Jmeno { get; set; }

        public string Prijmeni { get; set; }

        public string Id { get; set; }  

        public DateTime Datum { get; set; }

        public addNewWin() 
        { 
            InitializeComponent();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {

            Jmeno = jmeno.Text;
            Prijmeni = prijmeni.Text;
            Id = id.Text;
            Datum = datumNarozeni.SelectedDate ?? DateTime.Now;

        }
    }
}
 