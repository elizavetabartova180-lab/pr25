using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Bartova.Interfaces;
using Shop_Bartova.Models;

namespace Shop_Bartova.Classes
{
    public class SportContext : Sport, IContext
    {
        public SportContext() { }

        public SportContext(int id, string name, int price, string size, int idShop)
            : base(id, name, price, size, idShop) { }

        public List<object> All()
        {
            List<object> allShop = new ShopContext().All();
            List<object> allSport = new List<object>();

            OleDbConnection connection = Common.DBConnection.Connection();
            OleDbDataReader sportData = Common.DBConnection.Query(
                "SELECT * FROM [Спорттовары]", connection);

            while (sportData.Read())
            {
                ShopContext shopElement = allShop.Find(
                    x => (x as ShopContext).Id == sportData.GetInt32(2)) as ShopContext;

                SportContext newSport = new SportContext(
                    shopElement.Id,
                    shopElement.Name,
                    shopElement.Price,
                    sportData.GetString(1),
                    sportData.GetInt32(2)
                );

                allSport.Add(newSport);
            }

            Common.DBConnection.CloseConnection(connection);
            return allSport;
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void Save(bool Update = false)
        {
            throw new System.NotImplementedException();
        }
    }
}
