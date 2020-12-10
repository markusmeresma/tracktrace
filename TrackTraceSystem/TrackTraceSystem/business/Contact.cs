using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackTraceSystem.data;

namespace TrackTraceSystem.business
{
    class Contact : Event
    {
        private User otherIndividual;

        public Contact(User user1, User user2) : base(user1)
        {
            otherIndividual = user2;
        }

        public User OtherIndividual
        {
            get
            {
                return otherIndividual;
            }

            set
            {
                otherIndividual = value;
            }
        }

        /*
         * Methods
         */

        //Get available contacs for user
        public static List<User> GetAvailableContacts(User user)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            //List to save available contacts
            List<User> availableContacts = new List<User>();

            //If selected user id is not equal to user id then add user to the available contacts list
            foreach (User u in User.GetUsers())
            {
                if (u.Id != user.Id)
                {
                    availableContacts.Add(u);
                }
            }

            return availableContacts;
        }

        //Save contact in the system
        public static void RecordContact(Contact contact)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            store.SaveContact(contact);
        }

        public override string ToString()
        {
            string contactString =
                "Details of recorded contact: " + "\n" +
                "Contact ID: " + Id + "\n" +
                "Contact date&time: " + DateTime + "\n";

            return contactString;
        }

        //Contact to csv
        public string ContactToCSV()
        {
            string csvRow =
                base.EventToCSV() + OtherIndividual;

            return csvRow;
        }
    }
}
