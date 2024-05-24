using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using restaurant_manager_app.DAO;
using restaurant_manager_app.DTO;

namespace restaurant_manager_app
{
    public partial class fTableManger : Form
    {
        public fTableManger()
        {
            InitializeComponent();
            loadtable();
          
        }

        #region Method
        void loadtable()
        {
            
            List<Table> tablelist = TableDAO.Instance.Loadtablelist();
            foreach(Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height =TableDAO.TableHeight};
                btn.Text = item.Soban + "\n" + item.Trangthai;
                btn.Click += btn_click;
                btn.Tag = item;
                switch(item.Trangthai)
                {
                    case "Có thể sử dụng":
                        btn.BackColor = Color.Green;
                        btn.ForeColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Gray;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        void showbill(int id)
        {
            //lsvbill.Items.Clear();
            /*  List<Bill> listbill = BIllDAO.Instance.Loadhoadon(id);
              foreach(Bill item in listbill)
              {
                  ListViewItem lsvItem = new ListViewItem(item.Id.ToString());
                  lsvItem.SubItems.Add(item.Manv.ToString());
                  lsvItem.SubItems.Add(item.Trigia.ToString());

                  lsvItem.SubItems.Add(item.Soban.ToString());
                  lsvItem.SubItems.Add(item.Ngayhd.ToString());
                  lsvItem.SubItems.Add(item.Status.ToString());
                  lsvbill.Items.Add(lsvItem);
              }*/
            List<DTO.Menu> listmenu = MenuDAO.Instance.laydanhsachmonan(id);
            foreach(DTO.Menu item in listmenu)
            {
                ListViewItem lsvitem = new ListViewItem(item.Temon.ToString());
                lsvitem.SubItems.Add(item.Soluong.ToString());
                lsvbill.Items.Add(lsvitem);
            }

        }


        #endregion
        #region event
        private void btn_click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).Soban;
            showbill(TableID);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
