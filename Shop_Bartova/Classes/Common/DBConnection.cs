using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Shop_Bartova.Classes.Common
{
   public class DBConnection
    {
        public static string Path = @"C:\Users\student-A502.PERMAVIAT\Downloads\Shop_Bartovanew-master\Shop_Bartovanew-master\Shop_Bartova\DB.accdb";
        public static OleDbConnection Connection()
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Path);
            oleDbConnection.Open();
            return oleDbConnection;
        }
        public static OleDbDataReader Query(string sql, OleDbConnection connection)
        {
            return new OleDbCommand(sql, connection).ExecuteReader();
        }
        public static void CloseConnection(OleDbConnection connection)
        {
            connection.Close();
        }
    }
}
