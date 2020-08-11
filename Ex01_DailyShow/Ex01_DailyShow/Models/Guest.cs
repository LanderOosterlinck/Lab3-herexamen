using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01_DailyShow.Models
{
    public class Guest
    {
        //YEAR;GoogleKnowlege_Occupation;Show;Group;Raw_Guest_List
        public String Year { get; set; } //jaar
        public String GoogleKnowlegeOccupation { get; set; }
        public DateTime Show { get; set; } //datum
        public String Group { get; set; }
        public String Name { get; set; }

        //methods 
        public override string ToString()
        {
            return this.Name + "(" + this.Group + ")";
        }

        public Guest()
        {

        }
    }
}
