using restaurant_manager_app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_app.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        private MenuDAO() { }

        public static MenuDAO Instance { get { if (instance == null) instance = new MenuDAO(); return instance; } set => instance = value; }

       
       
        public List<Menu> laydanhsachmonan(int soban)
        {
            List<Menu> listmenu = new List<Menu>();
            string sql = "SELECT dbo.MENU.TenMon, dbo.CHEBIEN.SoLuong, dbo.MENU.Gia, dbo.MENU.Gia * dbo.CHEBIEN.SoLuong as tongtien" +
                " FROM     dbo.BAN INNER JOIN" +
                "dbo.CHEBIEN ON dbo.BAN.SoBan = dbo.CHEBIEN.SoBan INNER JOIN" +
                "dbo.MENU ON dbo.CHEBIEN.MaMon = dbo.MENU.MaMon" +
                "dbo.BAN.TrangThai =N'Có thể sử dụng' and where dbo.BAN.SoBan = " + soban;
            
            DataTable dtlistmenu = DataSeviecs.Instance.RunQuery(sql);

            foreach(DataRow item in dtlistmenu.Rows)
            {
                Menu table = new Menu(item);
                listmenu.Add(table);
                  
            }
            return listmenu;
        }
    
    
    }

}
