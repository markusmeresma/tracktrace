using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackTraceSystem.business;

namespace TrackTraceSystem.data
{
    class Store
    {
        /*
         * This class implements store from the data layer using Singleton design pattern to ensure that only one instance is created
         */

        //Singleton code
        //Holds a reference to the only Store object
        private static Store instance;

        List<User> users = new List<User>();
        List<Location> locations = new List<Location>();
        List<Visit> visits = new List<Visit>();
        List<Contact> contacts = new List<Contact>();
        CSVHandler csvHandler = new CSVHandler();

        private Store() { }

        //Property to access the only instance of the Store
        public static Store Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Store();
                }
                return instance;
            }
        }
        //Done Singleton code

        /*
         * Methods
         */

        //Generate unique id for each user
        public Guid GenerateUserId()
        {
            Guid id = Guid.NewGuid();

            return id;
        }

        //Generate unique id for each location
        public Guid GenerateLocationId()
        {
            Guid id = Guid.NewGuid();

            return id;
        }

        //Generate unique id for each event
        public Guid GenerateEventId()
        {
            Guid id = Guid.NewGuid();

            return id;
        }

        //Save user in the system
        public void SaveUser(User user)
        {
            users.Add(user);
            csvHandler.writeUserToCSV(user);
        }

        //get user from the list
        public User GetUser(string _phoneNr)
        {
            //Linq query to get a user from the list
            var querySingleUser = from user in users
                                  where user.PhoneNr == _phoneNr
                                  select user;

            return querySingleUser.FirstOrDefault();
        }

        //Save location in the system
        public void SaveLocation(Location location)
        {
            locations.Add(location);
            csvHandler.writeLocationToCSV(location);
        }

        //Get location from the list
        public Location GetLocation(string _address)
        {
            //Linq query to get a location from the list
            var querySingleLocation = from location in locations
                                      where location.Address == _address
                                      select location;

            return querySingleLocation.FirstOrDefault();
        }

        //Save visit in the list
        public void SaveVisit(Visit visit)
        {
            visits.Add(visit);
            csvHandler.writeVisitsToCSV(visit);
        }

        //Save contact in the list
        public void SaveContact(Contact contact)
        {
            contacts.Add(contact);
            csvHandler.writeContactsToCSV(contact);
        }

        //Provide access to contacts in the system
        public List<Contact> LoadContacts()
        {
            return contacts;
        }

        //Provide access to visits in the system
        public List<Visit> LoadVisits()
        {
            return visits;
        }

        //Provide access to users in the system
        public List<User> LoadUsers()
        {
            return users;
        }

        //Provide access to locations in the system
        public List<Location> LoadLocations()
        {
            return locations;
        }

        //Check mobile phone nr uniqueness
        public bool CheckPhoneNrUniqueness(string phoneNr)
        {
            foreach (User u in users)
            {
                if (u.PhoneNr.Equals(phoneNr) != false)
                {
                    //Return false if number is already in the system
                    return false;
                }
            }
            return true;
        }

        

    }
}
