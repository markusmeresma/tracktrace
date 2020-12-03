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
            //Fix validation (add validation to .xaml.cs file)
            try
            {
                
            }
            catch (Exception e)
            {
                throw new Exception("Please insert a valid UK phone number (example: xxx)");
            }

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

        //NB! - Fix validation
        //Validate UK phone number
        private bool ValidateUKPhoneNr(string number)
        {
            return Regex.Match(number, @"^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}$", RegexOptions.IgnoreCase).Success;
        }
    }
}
