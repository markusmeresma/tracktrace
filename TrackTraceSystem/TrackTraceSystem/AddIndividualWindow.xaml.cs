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
using TrackTraceSystem.business;
using TrackTraceSystem.data;

namespace TrackTraceSystem
{
    /// <summary>
    /// Interaction logic for AddIndividualWindow.xaml
    /// </summary>
    public partial class AddIndividualWindow : Window
    {
        public AddIndividualWindow()
        {
            InitializeComponent();
        }

        private void btnSaveIndividual_Click(object sender, RoutedEventArgs e)
        {
            //Validate phone nr before calling constructor with arguments

            User user = new User(txtPhoneNr.Text);
            //Get access to the datalayer
            Store store = Store.Instance;

            //Save user in the system
            store.SaveUser(user);

            //Add user's phone number to ListBox
            ListBox.Items.Add(user.Id);

            txtPhoneNr.Text = String.Empty;
        }

       
    }
}
