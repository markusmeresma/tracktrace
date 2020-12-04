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
        Store store = Store.Instance;

        //Constructor with arguments to instantiate User object
        public User(string _phoneNr)
        {
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
    }
}
