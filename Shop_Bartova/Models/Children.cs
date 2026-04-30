using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shop_Bartova.Models
{
    public class Children : Shop
    {
        public int Age;
        public int IdShop;
        public Children() { }
        public Children(int id, string name, int price, int age, int idShop) : base(id, name, price)
        {
            this.Age = age;
            this.IdShop = idShop;
        }
    }
}
