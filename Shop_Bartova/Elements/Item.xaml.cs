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
            Models.Shop ShopData = item as Models.Shop;
            td_Name.Content = ShopData.Name;
            td_Price.Content = "Цена:" + ShopData.Price;
            if (item is Models.Children)
            {
                Models.Children ChildrenData = item as Models.Children;
                td_Characteristic.Content = "Возраст:" + ChildrenData.Age;
            }
            if (item is Models.Sport) {
                Models.Sport SportData = item as Models.Sport;
                td_Characteristic.Content = "Размер:" + SportData.Size;

            }
        }
    }
}
