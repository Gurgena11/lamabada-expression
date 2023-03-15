using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms1
{
    internal class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        public override string ToString()
        {
            return $"Name {Name} Lastname {LastName} DOB {DOB.ToShortDateString()}";
        }
    }
}
