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
    public class ShopContext : Shop, IContext
    {
        public ShopContext() { }
        public ShopContext(int id, string name, int price): base(id, name, price) { }
        public List<object> All()
        {
            List<object> allShop = new List<object>();
            OleDbConnection Connection = Common.DBConnection.Connection();
            OleDbDataReader ShopData = Common.DBConnection.Query(
                "SELECT * FROM [Товар]", Connection);
            while (ShopData.Read())
            {
                allShop.Add(new ShopContext(
                    ShopData.GetInt32(0),
                    ShopData.GetString(1),
                    ShopData.GetInt32(2)
                    ));
            }
            Common.DBConnection.CloseConnection(Connection);
            return allShop;
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
