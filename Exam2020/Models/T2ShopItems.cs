using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2020.Models
{
    public class T2ShopItems
    {
        public int Id { get; set; }
        public virtual T2Model T2Model { get; set; }
        public int Numbers { get; set; }
        public int Coast { get; set; }
        public T2Shop T2Shop { get; set; }
    }
}
