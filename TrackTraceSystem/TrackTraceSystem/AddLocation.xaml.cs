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
    /// Interaction logic for AddLocation.xaml
    /// </summary>
    public partial class AddLocation : Window
    {
        public AddLocation()
        {
            InitializeComponent();

            //Get access to the datalayer
            Store store = Store.Instance;

            //Populate ListBox to show locations in the system
            foreach (Location l in store.LoadLocations())
            {
                ListBox.Items.Add(l.Id);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Validate here that type input is string, address might contain numbers (add a separate method for this to this class)
            try
            {
                if (Location.IsValidType(txtType.Text) != true)
                {
                    throw new ArgumentException("Type must only contain letters");
                }
                else if (Location.IsValidAddress(txtAddress.Text) != true)
                {
                    throw new ArgumentException("Address must only contain numbers and letters");
                }
                else
                {
                    Location location = new Location(txtType.Text, txtAddress.Text);
                    //Get access to the datalyer
                    Store store = Store.Instance;

                    //Save location in the system
                    store.SaveLocation(location);

                    //Add location to the listbox
                    ListBox.Items.Add(location.Type);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtType.Text = String.Empty;
            txtAddress.Text = String.Empty;
        }
    }
}
