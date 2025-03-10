using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt2._0.Models
{
    public class Proprietary
    {
        public string Clothes { get; set; }
        public string Subjects { get; set; }
        public string Electronics { get; set; }

        public Proprietary(string clought, string subjects, string electronics) 
        {
            this.Clothes = clought;
            this.Subjects = subjects;
            this.Electronics = electronics;
        }
    }
}
