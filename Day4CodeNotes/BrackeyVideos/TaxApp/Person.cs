using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp
{
    public class Person
    {
        private string _firstName; // creates the full property of the persons FirstName

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                _firstName = value;
                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }

        private string _lastName;  // creates the full property of the persons LastName

        public string LastName
        {
            get { return _lastName; }
            set 
            { 
                _lastName = value;
                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }
        
        public int Age { get; set; }
    }
}
