using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackTraceSystem.business;

namespace TrackTraceSystem.data
{
    class CSVHandler
    {
        private const string usersFile = @"C:\Users\Markus Meresma\users.csv";
        private string usersHEADER = "id,PhoneNr";

        private const string locationsFile = @"C:\Users\Markus Meresma\locations.csv";
        private string locationsHEADER = "id,type,address";

        private const string contactsFile = @"C:\Users\Markus Meresma\contacts.csv";
        private string contactsHEADER = "id,datetime,user1,user2";

        private const string visitsFile = @"C:\Users\Markus Meresma\visits.csv";
        private string visitsHEADER = "id,datetime,user,location";

        //Constructor to delete files if they exist and create new files
        public CSVHandler()
        {
            //Delete user csv, if it exists
            if (File.Exists(usersFile))
            {
                File.Delete(usersFile);
            }
            //Create users csv and add header row
            using (StreamWriter userWriter = new StreamWriter(usersFile, true))
            {
                userWriter.WriteLine(usersHEADER);
            }

            //Delete location csv, if it exists
            if (File.Exists(locationsFile))
            {
                File.Delete(locationsFile);
            }
            //Create locations csv and add header row
            using (StreamWriter locationWriter = new StreamWriter(locationsFile, true))
            {
                locationWriter.WriteLine(locationsHEADER);
            }

            //Delete contacts csv, if it exists
            if (File.Exists(contactsFile))
            {
                File.Delete(contactsFile);
            }
            //Create contacts csv and add header row
            using (StreamWriter contactsWriter = new StreamWriter(contactsFile, true))
            {
                contactsWriter.WriteLine(contactsHEADER);
            }

            //Delete visits csv, if it exists
            if (File.Exists(visitsFile))
            {
                File.Delete(visitsFile);
            }
            //Create visits csv and add header row
            using (StreamWriter visitsWriter = new StreamWriter(visitsFile, true))
            {
                visitsWriter.WriteLine(visitsHEADER);
            }
        }

        public void writeUserToCSV(User user)
        {
            using (StreamWriter userWriter = new StreamWriter(usersFile, true))
            {
                userWriter.WriteLine(user.UserToCSV());
            }
        }

        public void writeLocationToCSV(Location location)
        {
            using (StreamWriter locationWriter = new StreamWriter(locationsFile, true))
            {
                locationWriter.WriteLine(location.LocationToCSV());
            }
        }
    }
}
