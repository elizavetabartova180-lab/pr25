using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bartova.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems() {
            List<object> allItems = new List<object>();
            allItems.Add(new Models.Children("Игрушка интерактивная", 2200, 3));
            allItems.Add(new Models.Children("Кактус танцующий", 894, 6));
            allItems.Add(new Models.Children("Мягкая игрушка кошка подушка", 1754, 6));
            allItems.Add(new Models.Sport("Спортивный мужской костюм", 4913, "S"));
            allItems.Add(new Models.Sport("Мяч для водного поло", 812, "61-63 см"));
            allItems.Add(new Models.Sport("Набор для гольфа Partida", 3950, "600-800 мм"));
            return allItems;
        }
    }
}
