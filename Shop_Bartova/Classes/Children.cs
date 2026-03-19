using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bartova.Classes
{
    public class Children : Shop
    {
        public int Age { get; set; }
        public Children(string name, int price, int age) : base(name, price)
        {
            this.Age = age;
        }
    }
}
