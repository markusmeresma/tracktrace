using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrackTraceSystem.data;

namespace TrackTraceSystem.business
{
    abstract class Event
    {
        private Guid id;
        private DateTime dateTime;
        private User individual;

        public Event(User user1)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            id = store.GenerateEventId();
            individual = user1;
        }

        public Guid Id
        {
            get
            {
                return id;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
            }
        }

        public User Individual
        {
            get
            {
                return individual;
            }

            set
            {
                individual = value;
            }
        }

        /*
         * Methods
         */

        public static bool ValidateDate(string _date)
        {
            /*
             * Regex from https://www.regextester.com/99555
             * Date fomrat: dd/mm/yyyy
             */

            return Regex.IsMatch(_date, @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$");
        }

        public static bool ValidateTime(string _time)
        {
            /*
             * Regex from https://stackoverflow.com/questions/7536755/regular-expression-for-matching-hhmm-time-format/7536768 (Niket Pathak)
             * Time format: HH:MM (24-hour format)
             */

            return Regex.IsMatch(_time, @"^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
        }
    }
}
