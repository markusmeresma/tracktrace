using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackTraceSystem.data;

namespace TrackTraceSystem.business
{
    class Visit : Event
    {
        private Location visitLocation;

        public Visit(User user1, Location location) : base(user1)
        {
            visitLocation = location;
        }

        public Location VisitLocation
        {
            get
            {
                return visitLocation;
            }

            set
            {
                visitLocation = value;
            }
        }

        /*
         * Methods
         */

        //Save visit in the system
        public static void RecordVisit(Visit visit)
        {
            //Get access to the data layer
            Store store = Store.Instance;

            store.SaveVisit(visit);
        }

        public override string ToString()
        {
            string visitString = 
                "Details of recorded visit: \n" +
                "ID: " + Id + "\n" +
                "DateTime: " + DateTime + "\n" +
                "Location: " + visitLocation.Address + "\n";

            return visitString;
        }

        //Visit to csv
        public string VisitToCSV()
        {
            string csvRow =
                base.EventToCSV() + visitLocation.Address + "," + visitLocation.Type;

            return csvRow;
        }
    }
}
