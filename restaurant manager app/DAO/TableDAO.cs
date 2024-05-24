using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant_manager_app.DTO;
using System.Data;

namespace restaurant_manager_app.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance { get { if (instance == null) instance = new TableDAO(); return instance; } set => instance = value; }
        private  TableDAO() { }

        public static int TableWidth = 150;
        public static int TableHeight = 150;

        public List<Table> Loadtablelist()
        {
            List<Table> tablelist = new List<Table>();

            DataTable dtfood = DataSeviecs.Instance.RunQuery("exec gettablelist");
            //cho mõi hàng
            foreach(DataRow item in dtfood.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }

            return tablelist; 
        }
    }

   

}
