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
         * This class implements a store for the data layer using Singleton design pattern to ensure that only one instance is created
         */

        //Singleton code
        //Holds a reference to the only Store object
        private static Store instance;
        List<User> users = new List<User>();
        List<Location> locations = new List<Location>();

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

        //Save user in the system
        public void SaveUser(User user)
        {
            users.Add(user);
        }

        //Save location in the system
        public void SaveLocation(Location location)
        {
            locations.Add(location);
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
