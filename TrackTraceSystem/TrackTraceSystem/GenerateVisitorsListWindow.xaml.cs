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
using TrackTraceSystem.data;

namespace TrackTraceSystem
{
    /// <summary>
    /// Interaction logic for GenerateVisitorsListWindow.xaml
    /// </summary>
    public partial class GenerateVisitorsListWindow : Window
    {
        public GenerateVisitorsListWindow()
        {
            InitializeComponent();
            locationListBox_GetLocations();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            listOfVisitorsListBox.Items.Clear();

            try
            {
                if (Visit.ValidateDate(txtStartDate.Text) != true)
                {
                    throw new System.ArgumentException("Invalid Start Date");
                }
                else if (Visit.ValidateTime(txtStartTime.Text) != true)
                {
                    throw new System.ArgumentException("Invalid Start Time");
                }
                else if (Visit.ValidateDate(txtEndDate.Text) != true)
                {
                    throw new System.ArgumentException("Invalid End Date");
                }
                else if (Visit.ValidateTime(txtEndTime.Text) != true)
                {
                    throw new System.ArgumentException("Invalid End Time");
                }
                else
                {
                    //Get location
                    Location specifiedLocation = Location.GetLocation(txtSpecifiedLocation.Text);

                    string startDateTimeString = String.Concat(txtStartDate.Text, " ", txtStartTime.Text);
                    string endDateTimeString = String.Concat(txtEndDate.Text, " ", txtEndTime.Text);

                    DateTime specifiedStartDateTime = DateTime.ParseExact(startDateTimeString, "dd/MM/yyyy HH:mm", CultureInfo.CreateSpecificCulture("en-GB"));
                    DateTime specifiedEndDateTime = DateTime.ParseExact(endDateTimeString, "dd/MM/yyyy HH:mm", CultureInfo.CreateSpecificCulture("en-GB"));

                    //Check if start date is before end date
                    IsStartDateBeforeEndDate(specifiedStartDateTime, specifiedEndDateTime);

                    ListGenerator generateVisitorsListForSpecifiedLocation = new ListGenerator();

                    foreach (User u in generateVisitorsListForSpecifiedLocation.visitorsBetweenDates(specifiedLocation, specifiedStartDateTime, specifiedEndDateTime))
                    {
                        listOfVisitorsListBox.Items.Add(u.PhoneNr);
                    }

                    //Display message if no visitors found
                    if (listOfVisitorsListBox.Items.Count == 0)
                    {
                        MessageBox.Show("No visitors found");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtStartDate.Text = String.Empty;
            txtEndDate.Text = String.Empty;
            txtStartTime.Text = String.Empty;
            txtEndTime.Text = String.Empty;
        }

        private void locationListBox_GetLocations()
        {
            foreach (Location l in Location.GetLocations())
            {
                specifiedLocationListBox.Items.Add(l.Address);
            }
        }

        private void specifiedLocationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtSpecifiedLocation.Text = specifiedLocationListBox.SelectedItem.ToString();
        }

        private void IsStartDateBeforeEndDate(DateTime startDate, DateTime endDate)
        {
            try
            {
                if (startDate > endDate)
                {
                    throw new System.ArgumentException("Start date cannot be after end date");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
