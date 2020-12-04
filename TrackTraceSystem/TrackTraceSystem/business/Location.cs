using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrackTraceSystem.data;

namespace TrackTraceSystem.business
{
    class Location
    {
        private Guid id;
        private string type;
        private string address;
        //Get access to the data layer
        Store store = Store.Instance;

        public Location(string _type, string _address)
        {
            type = _type;
            address = _address;
            id = store.GenerateLocationId();
        }

        public Guid Id
        {
            get
            {
                return id;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        /*
         * Methods
         */

        //Validate location type
        public static bool IsValidType(string _type)
        {
            //Location type might only contain letters (shop, cafe, etc)
            return Regex.IsMatch(_type, @"^[a-zA-Z]+$");
        }

        //Validate location address
        public static bool IsValidAddress(string _address)
        {
            //Address might contain only letters and numbers
            return Regex.IsMatch(_address, @"^[a-zA-Z0-9_ ]+$");
        }
    }
}
