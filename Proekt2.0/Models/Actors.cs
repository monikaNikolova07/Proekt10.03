using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt2._0.Models
{
    public class Actors
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Actors(string firstName, string lastName,string city) 
        { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
        }
    }
}
