using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2020.Models
{
    public class T2Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<T2ShopItems> T2ShopItems { get; set; }
    }
}
