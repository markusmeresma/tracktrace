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
    /// Interaction logic for RecordVisitWindow.xaml
    /// </summary>
    public partial class RecordVisitWindow : Window
    {
        public RecordVisitWindow()
        {
            InitializeComponent();
            individualListBox_GetUsers();
            locationListBox_GetLocations();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Visit.ValidateDate(txtDate.Text) != true)
                {
                    throw new System.ArgumentException("Invalid date");
                }
                else if (Visit.ValidateTime(txtTime.Text) != true)
                {
                    throw new System.ArgumentException("Invalid time");
                }
                else
                {
                    //Get user from the list
                    User user1 = User.GetUser(txtVisitIndividual.Text);

                    //Get location from the list
                    Location location = Location.GetLocation(txtVisitLocation.Text);

                    Visit visit = new Visit(user1, location);

                    //Concatenate date and time
                    string dateTimeString = String.Concat(txtDate.Text, " ", txtTime.Text);

                    //Add date and time to DateTime struct
                    visit.DateTime = DateTime.Parse(dateTimeString);

                    Visit.RecordVisit(visit);

                    //Show recorded visit details
                    MessageBox.Show(visit.ToString() + "User ID: " + user1.Id + "\n" + "Phone nr: " + user1.PhoneNr);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtVisitIndividual.Text = String.Empty;
            txtVisitLocation.Text = String.Empty;
            txtDate.Text = String.Empty;
            txtTime.Text = String.Empty;
        }

        //Display users in the individuals listbox
        private void individualListBox_GetUsers()
        {
            foreach (User u in User.GetUsers())
            {
                individualListBox.Items.Add(u.PhoneNr);
            }
        }

        //Display locations in the locations listbox
        private void locationListBox_GetLocations()
        {
            foreach (Location l in Location.GetLocations())
            {
                locationListBox.Items.Add(l.Address);
            }
        }

        private void individualListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtVisitIndividual.Text = individualListBox.SelectedItem.ToString();
        }

        private void locationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtVisitLocation.Text = locationListBox.SelectedItem.ToString();
        }
    }
}
