using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace restaurant_manager_app.DTO
{
    public class Menu
    {
        public Menu(string tennmon, int soluong, int gia, int tongtien)
        {
            this.Temon = tennmon;
            this.Soluong = soluong;
            this.Gia = gia;
            this.Tongtien = tongtien;
        }

        public Menu(DataRow row)
        {
            this.Temon = row["dbo.MENU.TenMon"].ToString();
            this.Soluong = (int)row["dbo.CHEBIEN.SoLuong"];
            this.Gia = (int)row["dbo.MENU.Gia"];
            this.Tongtien = (int)row["tongtien"];
        }
        private string temon;
        private int soluong;
        private int gia;
        private int tongtien;

        public string Temon { get => temon; set => temon = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
