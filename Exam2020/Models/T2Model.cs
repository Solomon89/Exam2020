using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2020.Models
{
    public class T2Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual T2Manufecturer T2Manufecturer { get; set; }
    }
}
