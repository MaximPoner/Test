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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zaměstnanec> zamestnanci = new List<Zaměstnanec>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateEvidenceListBox()
        {
            Evidence.ItemsSource = null;
            Evidence.ItemsSource = zamestnanci;
        }

        private void addNew_Click(object sender, RoutedEventArgs e)
        {
                addNewWin addNewWin = new addNewWin();
            addNewWin.ShowDialog();

            if(addNewWin.DialogResult == true)
            {
                var newZamestnanec = new Zaměstnanec
                {
                    Jméno = addNewWin.Jmeno,
                    Příjmení = addNewWin.Prijmeni,
                    ID = addNewWin.Id,
                    Datum = addNewWin.Datum
                };
            }
        }


        private void Evidence_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



    }
}
