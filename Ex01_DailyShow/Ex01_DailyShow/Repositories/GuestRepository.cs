using Ex01_DailyShow.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace Ex01_DailyShow.Repositories
{
    public static class GuestRepository
    {
        public static List<Guest> ReadGuests()
        {
            List<Guest> guests = new List<Guest>();

            string resourceId = "Ex01_DailyShow.Assets.daily_show_guests.csv";
            var assembly = typeof(Guest).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(resourceId);

            using (var reader = new System.IO.StreamReader(stream))
            {

                //read the first line and ignore it (= title line, no data)
                reader.ReadLine();

                string line = reader.ReadLine();

                while(line!=null)
                {
                    string[] parts = line.Split(';');

                    try
                    {
                        Guest guest = new Guest();
                        //YEAR;GoogleKnowlege_Occupation;Show;Group;Raw_Guest_List
                        guest.Year = parts[0];
                        guest.GoogleKnowlegeOccupation = parts[1];
                        guest.Show = Convert.ToDateTime(parts[2]);
                        guest.Group = parts[3];
                        guest.Name = parts[4];

                        guests.Add(guest);
                    }
                    catch(Exception)
                    {
                        Debug.WriteLine("error processing line:" + line);
                    }

                    line = reader.ReadLine();
                }
            }
            return guests;
        }
    }
}
