using restaurant_manager_app.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_manager_app
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string ID = txtUserName.Text;
            string MatKhau = txtPassword.Text;
            if (login(ID,MatKhau ))
            { 
                fTableManger f = new fTableManger();
                this.Hide();
                f.ShowDialog();
                this.Show();
            

            }
            else
            {
                MessageBox.Show("Sai thông tin hoặc mật khẩu", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool login(string ID, string MatKhau)
        {
            return AccountDAO.Instance.login(ID, MatKhau);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("bạn có muón thoát chương trình","thông báo", MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
