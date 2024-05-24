
namespace restaurant_manager_app
{
    partial class fTableManger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvbill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodCounnt = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCounnt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvbill);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(549, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 410);
            this.panel2.TabIndex = 2;
            // 
            // lsvbill
            // 
            this.lsvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvbill.HideSelection = false;
            this.lsvbill.Location = new System.Drawing.Point(3, 3);
            this.lsvbill.Name = "lsvbill";
            this.lsvbill.Size = new System.Drawing.Size(460, 407);
            this.lsvbill.TabIndex = 0;
            this.lsvbill.UseCompatibleStateImageBehavior = false;
            this.lsvbill.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(3, 706);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 85);
            this.panel1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(187, 47);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chuyển bàn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(187, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Giảm giá";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(367, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 79);
            this.button3.TabIndex = 1;
            this.button3.Text = "Thanh toán";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Location = new System.Drawing.Point(549, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 85);
            this.panel3.TabIndex = 3;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(4, 47);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(112, 24);
            this.cbSwitchTable.TabIndex = 3;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(187, 47);
            this.nmDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(120, 22);
            this.nmDiscount.TabIndex = 2;
            this.nmDiscount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSwitchTable.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.Location = new System.Drawing.Point(1, 0);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(115, 41);
            this.btnSwitchTable.TabIndex = 1;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDiscount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Location = new System.Drawing.Point(187, 0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(120, 41);
            this.btnDiscount.TabIndex = 1;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPay.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(367, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(96, 79);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCounnt);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Location = new System.Drawing.Point(549, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 69);
            this.panel4.TabIndex = 4;
            // 
            // nmFoodCounnt
            // 
            this.nmFoodCounnt.Location = new System.Drawing.Point(386, 24);
            this.nmFoodCounnt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCounnt.Name = "nmFoodCounnt";
            this.nmFoodCounnt.Size = new System.Drawing.Size(77, 22);
            this.nmFoodCounnt.TabIndex = 2;
            this.nmFoodCounnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddFood.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(284, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(96, 63);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 12);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(260, 24);
            this.cbFood.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AllowDrop = true;
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(0, 43);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(543, 599);
            this.flpTable.TabIndex = 5;
            // 
            // fTableManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 654);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManger";
            this.Text = "Phần mềm quản lí nhà hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCounnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCounnt;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lsvbill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}