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
    /// Interaction logic for GenerateContactListWindow.xaml
    /// </summary>
    public partial class GenerateContactListWindow : Window
    {
        public GenerateContactListWindow()
        {
            InitializeComponent();
            individualListBox_GetUsers();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            //Clear listbox if necessary
            listOfContactsListBox.Items.Clear();

            try
            {
                if (Contact.ValidateDate(txtDate.Text) != true)
                {
                    throw new System.ArgumentException("Invalid date");
                }
                else if (Contact.ValidateTime(txtTime.Text) != true)
                {
                    throw new System.ArgumentException("Invalid time");
                }
                else
                {
                    //Get specified individual
                    User specifiedIndividual = User.GetUser(txtSpecifiedIndividual.Text);

                    //Get specified date and time
                    string dateTimeString = String.Concat(txtDate.Text, " ", txtTime.Text);

                    DateTime specifiedDateTime = DateTime.Parse(dateTimeString); 

                    ListGenerator generateContactListForSpecifiedUser = new ListGenerator();

                    foreach (User u in generateContactListForSpecifiedUser.contactsAfterDate(specifiedIndividual, specifiedDateTime))
                    {
                        listOfContactsListBox.Items.Add(u.PhoneNr);
                    }

                    //Display message if no contacts found
                    if (listOfContactsListBox.Items.Count == 0)
                    {
                        MessageBox.Show("No contacts found");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtSpecifiedIndividual.Text = String.Empty;
            txtDate.Text = String.Empty;
            txtTime.Text = String.Empty;
        }

        private void individualListBox_GetUsers()
        {
            foreach (User u in User.GetUsers())
            {
                specifiedIndividualListBox.Items.Add(u.PhoneNr);
            }
        }

        private void specifiedIndividualListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtSpecifiedIndividual.Text = specifiedIndividualListBox.SelectedItem.ToString();
        }
    }
}
