using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite
{
    class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public string full_name
        {
            get
            {
                return $"{Name} {Family}";
            }
        }
    }    
}
