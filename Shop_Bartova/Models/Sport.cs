using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bartova.Models
{
    public class Sport: Shop
    {
        public string Size { get; set; }
        public int IdShop;
        public Sport() { }
        public Sport(int id, string name, int price, string size, int idShop) : base(id, name, price)
        {
            this.Size = size;
            this.IdShop = idShop;
        }
    }
}
