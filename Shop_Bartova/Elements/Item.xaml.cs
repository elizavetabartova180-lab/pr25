using System.ComponentModel.Design.Serialization;
using System.Windows.Controls;
using Shop_Bartova.Classes;

namespace Shop_Bartova.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(object item)
        {
            InitializeComponent();
            Shop ShopData = item as Shop;
            td_Name.Content = ShopData.Name;
            td_Price.Content = "Цена:" + ShopData.Price;
            if (item is Children)
            {
                Children ChildrenData = item as Children;
                td_Characteristic.Content = "Возраст:" + ChildrenData.Age;
            }
            if (item is Sport) { 
                Sport SportData = item as Sport;
                td_Characteristic.Content = "Размер:" + SportData.Size;

            }
        }
    }
}
