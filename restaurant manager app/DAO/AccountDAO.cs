using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace restaurant_manager_app.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            } 
            set => instance = value; 
        }
        private AccountDAO() { }

        public bool login(string ID, string MatKhau)
        {
            string sql = "select * from dbo.TAIKHOAN where ID = '" + ID + "' and MatKhau = '"+ MatKhau + "'";
            DataTable result = DataSeviecs.Instance.RunQuery(sql);
            return result.Rows.Count > 0;
        }
    }
}
