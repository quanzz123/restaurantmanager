using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace restaurant_manager_app.DTO
{
    public class Table
    {
      

        public  Table(int soban, string trangthai)
        {
            this.Soban = soban;
            this.Trangthai = trangthai;
        }

        //chuyển từng hàng thành list
        public Table(DataRow row)
        {
            this.Soban = (int)row["SoBan"];
            this.Trangthai = row["TrangThai"].ToString();
        }
        private int soban;
        private string trangthai;

        public int Soban { get => soban; set => soban = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }

        
    }
}
