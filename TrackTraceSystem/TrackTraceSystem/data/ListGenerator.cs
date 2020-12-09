using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackTraceSystem.business;

namespace TrackTraceSystem.data
{
    class ListGenerator
    {
        public ListGenerator() { }

        /*
         * Methods
         */

        //Get contact list for a specified user after a specified date
        public List<User> contactsAfterDate(User user, DateTime specifiedDateTime)
        {
            //Get access to data store
            Store store = Store.Instance;

            List<User> listForContactsAfterSpecifiedDate = new List<User>();

            foreach (Contact c in store.LoadContacts())
            {
                //Match user id and find contacts after specified date
                if (c.Individual.Id == user.Id && c.DateTime > specifiedDateTime)
                {
                    listForContactsAfterSpecifiedDate.Add(c.OtherIndividual);
                }
                else if (c.OtherIndividual.Id == user.Id && c.DateTime > specifiedDateTime)
                {
                    listForContactsAfterSpecifiedDate.Add(c.Individual);
                }
            }

            return listForContactsAfterSpecifiedDate;
        }


    }
}
