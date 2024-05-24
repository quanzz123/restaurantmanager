using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using restaurant_manager_app.DTO;

namespace restaurant_manager_app.DAO
{
    public class BIllDAO
    {
        private static BIllDAO instance;
        private BIllDAO() { }

        public static BIllDAO Instance { get { if (instance == null) instance = new BIllDAO(); return instance; } set => instance = value; }
        //thành công thì trả về bill id
        //thất bại thì trả về -1
        public int GETBILLBYIDTABLE(int id)
        {
            
            DataTable data = DataSeviecs.Instance.RunQuery("select * from dbo.HOADON where SoBan = "+ id +" and TrangThai = N'Chưa Trả'");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;

        }

        public List<Bill> Loadhoadon(int id)
        {
            List<Bill> tablelist = new List<Bill>();

            DataTable dtfood = DataSeviecs.Instance.RunQuery("select * from dbo.HOADON where SoBan = "+ id +" and TrangThai = N'Chưa Trả'");
            //cho mõi hàng
            foreach (DataRow item in dtfood.Rows)
            {
                Bill table = new Bill(item);
                tablelist.Add(table);
            }

            return tablelist;
        }
    }
}
