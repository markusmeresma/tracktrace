using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddIndividualWindow.xaml
    /// </summary>
    public partial class AddIndividualWindow : Window
    {
        public AddIndividualWindow()
        {
            InitializeComponent();
            
            //Populate ListBox to show users in the system
            foreach (User u in User.GetUsers())
            {
                ListBox.Items.Add(u.PhoneNr);
            }
        }

        private void btnSaveIndividual_Click(object sender, RoutedEventArgs e)
        {
            //Remove all whitespace from the input
            string _phoneNr = String.Concat(txtPhoneNr.Text.Where(c => !Char.IsWhiteSpace(c)));

            //Validate phone nr before saving user
            try
            {
                if (User.IsValidUKPhoneNr(_phoneNr) != true)
                {
                    throw new System.ArgumentException("Please insert a valid UK mobile phone nr");
                }
                else if (User.IsUniquePhoneNr(_phoneNr) != true)
                {
                    throw new System.ArgumentException("Number already exists in the system");
                }
                else
                {
                    //Create user
                    User user = new User(_phoneNr);

                    //Add user to the system
                    User.AddUser(user);

                    //Add user's phone number to ListBox
                    ListBox.Items.Add(user.PhoneNr);

                    txtPhoneNr.Text = String.Empty;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtPhoneNr.Text = String.Empty;
        }
    }
}
