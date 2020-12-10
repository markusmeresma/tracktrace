using System;
using System.Collections.Generic;
using System.Globalization;
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
            try
            {
                if (Contact.ValidateDate(txtDate.Text) != true)
                {
                    throw new ArgumentException("Invalid date");
                }
                else if (Contact.ValidateTime(txtTime.Text) != true)
                {
                    throw new ArgumentException("Invalid time");
                }
                else
                {
                    //Create individual 1
                    User user1 = User.GetUser(txtContactIndividual1.Text);

                    //Create individual 2
                    User user2 = User.GetUser(txtContactIndividual2.Text);

                    //Create a contact between individuals
                    Contact contact = new Contact(user1, user2);

                    string dateTimeString = String.Concat(txtDate.Text, " ", txtTime.Text);

                    //Add date and time to contact
                    contact.DateTime = DateTime.ParseExact(dateTimeString, "dd/MM/yyyy HH:mm", CultureInfo.CreateSpecificCulture("en-GB"));

                    //Record contact
                    Contact.RecordContact(contact);

                    //Display details
                    MessageBox.Show(contact.ToString() + "\n" +
                        "Individual 1" + "\n" +
                        "ID: " + user1.Id + "\n" +
                        "Phone nr: " + user1.PhoneNr + "\n" +
                        "Individual 2" + "\n" +
                        "ID: " + user2.Id + "\n" +
                        "Phone nr: " + user2.PhoneNr + "\n");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtContactIndividual1.Text = String.Empty;
            txtContactIndividual2.Text = String.Empty;
            txtDate.Text = String.Empty;
            txtTime.Text = String.Empty;
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
            //Clear contactIndividual2 textbox if there was any data
            txtContactIndividual2.Text = String.Empty;

            //Clear contactIndividual2ListBox if there was any data
            contactIndividual2ListBox.Items.Clear();
            
            txtContactIndividual1.Text = contactIndividual1ListBox.SelectedItem.ToString();

            //Change contacts available in contactIndividual2ListBox based on selected contact
            contactIndividual2ListBox_GetUsers();
        }

        private void contactIndividual2ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Handle null reference
            if (contactIndividual2ListBox.SelectedItem != null)
            {
                txtContactIndividual2.Text = contactIndividual2ListBox.SelectedItem.ToString();
            }
        }
    }
}
