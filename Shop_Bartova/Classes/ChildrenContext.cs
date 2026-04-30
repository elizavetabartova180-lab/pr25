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
    public class ChildrenContext : Children, IContext
    {
        public ChildrenContext() { }
        public ChildrenContext(int id, string name, int price, int age, int idShop) : base(id, name, price, age, idShop)
        {
        }

        public List<object> All()
        {
            List<object> allShop = new ShopContext().All();
            List<object> allChildren = new List<object>();
            OleDbConnection Connection = Common.DBConnection.Connection();
            OleDbDataReader ChildrenData = Common.DBConnection.Query(
                "SELECT * FROM [Детские вещи]", Connection);
            while (ChildrenData.Read())
            {
                ShopContext ShopElement = allShop.Find(x=> (x as ShopContext).Id == ChildrenData.GetInt32(2)) as ShopContext;
                allChildren.Add(new ChildrenContext(
                    ShopElement.Id,
                    ShopElement.Name,
                    ShopElement.Price,
                    ChildrenData.GetInt32(1),
                    ChildrenData.GetInt32(2)));
            }
            Common.DBConnection.CloseConnection(Connection);
            return allChildren;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save(bool Update = false)
        {
            throw new NotImplementedException();
        }
    }
}
