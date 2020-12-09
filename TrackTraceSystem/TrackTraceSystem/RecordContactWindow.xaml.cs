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

namespace TrackTraceSystem
{
    /// <summary>
    /// Interaction logic for RecordContactWindow.xaml
    /// </summary>
    public partial class RecordContactWindow : Window
    {
        public RecordContactWindow()
        {
            InitializeComponent();
            contactIndividual1ListBox_GetUsers();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void contactIndividual1ListBox_GetUsers()
        {
            foreach (User u in User.GetUsers())
            {
                contactIndividual1ListBox.Items.Add(u.PhoneNr);
            }
        }

        private void contactIndividual2ListBox_GetUsers()
        {
            //Get user from the list
            User user1 = User.GetUser(txtContactIndividual1.Text);

            foreach (User u in Contact.GetAvailableContacts(user1))
            {
                contactIndividual2ListBox.Items.Add(u.PhoneNr);
            }
        }

        private void contactIndividual1ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Clear contactIndividual2ListBox if there was any data
            contactIndividual2ListBox.Items.Clear();
            //Clear contactIndividual2 textbox if there was any data
            txtContactIndividual2.Text = String.Empty;

            txtContactIndividual1.Text = contactIndividual1ListBox.SelectedItem.ToString();

            //Change contacts available in contactIndividual2ListBox based on selected contact
            contactIndividual2ListBox_GetUsers();
        }

        private void contactIndividual2ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //is not handeling null 
            txtContactIndividual2.Text = contactIndividual2ListBox.SelectedItem.ToString();
        }
    }
}
