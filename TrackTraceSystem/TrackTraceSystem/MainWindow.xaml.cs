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

namespace TrackTraceSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddIndividual_Click(object sender, RoutedEventArgs e)
        {
            AddIndividualWindow newWin = new AddIndividualWindow();
            newWin.Show();
        }

        private void btnAddLocation_Click(object sender, RoutedEventArgs e)
        {
            AddLocation newWin = new AddLocation();
            newWin.Show();
        }

        private void btnRecordVisit_Click(object sender, RoutedEventArgs e)
        {
            RecordVisitWindow newWin = new RecordVisitWindow();
            newWin.Show();
        }

        private void btnRecordContact_Click(object sender, RoutedEventArgs e)
        {
            RecordContactWindow newWin = new RecordContactWindow();
            newWin.Show();
        }

        private void btnGenerateContactList_Click(object sender, RoutedEventArgs e)
        {
            GenerateContactListWindow newWin = new GenerateContactListWindow();
            newWin.Show();
        }
    }
}
