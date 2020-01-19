using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2020.Models
{
    public class T1Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<T1CarModel> T1CarModels { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
