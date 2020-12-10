using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrackTraceSystem.data;

namespace TrackTraceSystem.business
{
    class User
    {
        //GUID represents a globally unique identifier
        private Guid id;
        private string phoneNr;
        

        //Constructor with arguments to instantiate User object
        public User(string _phoneNr)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            id = store.GenerateUserId();
            phoneNr = _phoneNr;
        }

        public Guid Id
        {
            get
            {
                return id;
            }
        }

        public string PhoneNr
        {
            get
            {
                return phoneNr;
            }

            set
            {
                phoneNr = value;
            }
        }

        /*
         * Methods
         */

        //Validate UK mobile phone nr
        public static bool IsValidUKPhoneNr(string _phoneNr)
        {
            /*
             * Regex source https://stackoverflow.com/questions/25155970/validating-uk-phone-number-regex-c (Rahul Tripathi)
             * Example phone nrs
             * +447222555555
             * +44 7222 555 555
             * 07222 555 555
             */

            return Regex.IsMatch(_phoneNr, @"^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}$");
        }

        //Validate mobile phone nr uniqueness for the system
        public static bool IsUniquePhoneNr(string _phoneNr)
        {
            //Get access to the datalayer
            Store store = Store.Instance;

            //Return false if number exists in the system
            if (store.CheckPhoneNrUniqueness(_phoneNr) != true)
            {
                return false;
            }
            return true;
        }

        //Save user to the list
        public static void AddUser(User user)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            //Save user in the users list
            store.SaveUser(user);
        }

        //Access the list of users
        public static List<User> GetUsers()
        {
            //Get access to the data layer
            Store store = Store.Instance;

            return store.LoadUsers();
        }

        //Access a single user
        public static User GetUser(string _phoneNr)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            return store.GetUser(_phoneNr);
        }

        //User to csv
        public string UserToCSV()
        {
            string csvRow =
                Id + "," + PhoneNr;

            return csvRow; 
        }
    }
}
