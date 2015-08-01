using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Lab2
{
    public class Employee
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }  // the '?' following DateTime allows a non-nullable to be null

        public int? NumberOfYears { get; set; }

        //public Nullable<DateTime> EndDate { get; set; } // does the same as above


        
    }
}
