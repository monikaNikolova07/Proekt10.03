using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt2._0.Models
{
    public class Playes
    {
        public string Title { get; set; }
        public int Years { get; set; }

        public List<Actors> Actors { get; set; } = new List<Actors>();

        public Playes(string title, int years) 
        { 
            this.Title = title;
            this.Years = years;
        }
    }
}
