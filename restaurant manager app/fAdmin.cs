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


namespace restaurant_manager_app
{
    public partial class fAdmin : Form
    {
        
        public fAdmin()
        {
            InitializeComponent();
            loadlistfood();
        }
        void loadlistfood()
        {
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
