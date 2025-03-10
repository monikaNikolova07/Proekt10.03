using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt2._0.Models
{
    public class Theaters
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string City { get; set; }

        public List<Actors> Actors { get; set; } = new List<Actors>();
        public Theaters(string name, int year, string city)
        {
            this.Name = name;
            this.Year = year;
            this.City = city;
        }

    }
}
