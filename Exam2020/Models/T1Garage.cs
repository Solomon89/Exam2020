using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2020.Models
{
    public class T1Garage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<T1Auto> Cars { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
