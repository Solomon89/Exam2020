using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2020.Models
{
    public class T1Auto
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public T1CarModel T1Car { get; set; }
    }
}
