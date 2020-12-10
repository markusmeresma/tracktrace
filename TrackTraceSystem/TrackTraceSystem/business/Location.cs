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

        public Location(string _type, string _address)
        {
            //Get access to the data layer
            Store store = Store.Instance;

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

        //Save location in the system
        public static void AddLocation(Location location)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            //Save location to the list
            store.SaveLocation(location);
        }

        //Access locations
        public static List<Location> GetLocations()
        {
            //Get access to the data layer
            Store store = Store.Instance;

            return store.LoadLocations();
        }

        //Access a single location
        public static Location GetLocation(string _address)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            return store.GetLocation(_address);
        }

        //Location to csv
        public string LocationToCSV()
        {
            string csvRow =
                Id + "," + Type + "," + Address + "\n";

            return csvRow;
        }
    }
}
