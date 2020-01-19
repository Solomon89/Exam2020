using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2020.Models
{
    public class T1CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public T1Manufacturer T1Manufacturer { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
