namespace QuanLyQuanAn
{
    partial class chiNhanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.hoaDon = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPhiDichVu = new System.Windows.Forms.TextBox();
            this.tbxGiamGia = new System.Windows.Forms.TextBox();
            this.tbxTongCong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.soBan = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxLoaiHoaDon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxTenNV = new System.Windows.Forms.TextBox();
            this.tbxMaCN = new System.Windows.Forms.TextBox();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTàiKhoảnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label12 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_bot = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvDSBAN = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soBan)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.flpBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBAN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(765, 229);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(231, 20);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // hoaDon
            // 
            this.hoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.hoaDon.FullRowSelect = true;
            this.hoaDon.GridLines = true;
            this.hoaDon.Location = new System.Drawing.Point(5, 49);
            this.hoaDon.Name = "hoaDon";
            this.hoaDon.Size = new System.Drawing.Size(314, 278);
            this.hoaDon.TabIndex = 4;
            this.hoaDon.UseCompatibleStateImageBehavior = false;
            this.hoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Món";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SL";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ĐVT";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giá";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(631, 258);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 31);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "<< Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phí dịch vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giảm giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "TỔNG CỘNG:";
            // 
            // tbxPhiDichVu
            // 
            this.tbxPhiDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhiDichVu.Location = new System.Drawing.Point(122, 373);
            this.tbxPhiDichVu.Name = "tbxPhiDichVu";
            this.tbxPhiDichVu.Size = new System.Drawing.Size(197, 26);
            this.tbxPhiDichVu.TabIndex = 10;
            this.tbxPhiDichVu.Text = "0";
            this.tbxPhiDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxPhiDichVu.TextChanged += new System.EventHandler(this.tbxPhiDichVu_TextChanged);
            // 
            // tbxGiamGia
            // 
            this.tbxGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGiamGia.Location = new System.Drawing.Point(122, 408);
            this.tbxGiamGia.Name = "tbxGiamGia";
            this.tbxGiamGia.Size = new System.Drawing.Size(32, 26);
            this.tbxGiamGia.TabIndex = 11;
            this.tbxGiamGia.Text = "0";
            this.tbxGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxGiamGia.TextChanged += new System.EventHandler(this.tbxGiamGia_TextChanged);
            // 
            // tbxTongCong
            // 
            this.tbxTongCong.BackColor = System.Drawing.Color.Yellow;
            this.tbxTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTongCong.ForeColor = System.Drawing.Color.Red;
            this.tbxTongCong.Location = new System.Drawing.Point(122, 442);
            this.tbxTongCong.Name = "tbxTongCong";
            this.tbxTongCong.Size = new System.Drawing.Size(197, 29);
            this.tbxTongCong.TabIndex = 12;
            this.tbxTongCong.Text = "0";
            this.tbxTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.soBan);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbxLoaiHoaDon);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.hoaDon);
            this.panel1.Controls.Add(this.tbxTongCong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxGiamGia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxPhiDichVu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(299, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 473);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(154, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "%";
            // 
            // soBan
            // 
            this.soBan.Enabled = false;
            this.soBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soBan.Location = new System.Drawing.Point(281, 341);
            this.soBan.Name = "soBan";
            this.soBan.Size = new System.Drawing.Size(38, 26);
            this.soBan.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(211, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Số bàn:";
            // 
            // cbxLoaiHoaDon
            // 
            this.cbxLoaiHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiHoaDon.FormattingEnabled = true;
            this.cbxLoaiHoaDon.Items.AddRange(new object[] {
            "Tại chỗ",
            "Đem về",
            "Ship"});
            this.cbxLoaiHoaDon.Location = new System.Drawing.Point(122, 340);
            this.cbxLoaiHoaDon.Name = "cbxLoaiHoaDon";
            this.cbxLoaiHoaDon.Size = new System.Drawing.Size(83, 28);
            this.cbxLoaiHoaDon.TabIndex = 15;
            this.cbxLoaiHoaDon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "HOÁ ĐƠN";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(631, 484);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 70);
            this.button6.TabIndex = 17;
            this.button6.Text = "Thanh toán và in hoá đơn";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "KHÁCH HÀNG";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(120, 59);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 22);
            this.textBox5.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ngày mua";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(120, 87);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 22);
            this.textBox6.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbxTenNV);
            this.panel2.Controls.Add(this.tbxMaCN);
            this.panel2.Controls.Add(this.tbxMaNV);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(303, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 168);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(328, 65);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 66);
            this.button9.TabIndex = 30;
            this.button9.Text = "Tạo thành viên";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(457, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = "Thông tin tài khoản";
            // 
            // tbxTenNV
            // 
            this.tbxTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenNV.Location = new System.Drawing.Point(476, 113);
            this.tbxTenNV.Name = "tbxTenNV";
            this.tbxTenNV.ReadOnly = true;
            this.tbxTenNV.Size = new System.Drawing.Size(198, 22);
            this.tbxTenNV.TabIndex = 19;
            // 
            // tbxMaCN
            // 
            this.tbxMaCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaCN.Location = new System.Drawing.Point(476, 85);
            this.tbxMaCN.Name = "tbxMaCN";
            this.tbxMaCN.ReadOnly = true;
            this.tbxMaCN.Size = new System.Drawing.Size(198, 22);
            this.tbxMaCN.TabIndex = 19;
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaNV.Location = new System.Drawing.Point(476, 57);
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.ReadOnly = true;
            this.tbxMaNV.Size = new System.Drawing.Size(198, 22);
            this.tbxMaNV.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(409, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Tên:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(409, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Mã CN:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(409, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Mã NV:";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinToolStripMenuItem,
            this.tạoTàiKhoảnMớiToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // sửaThôngTinToolStripMenuItem
            // 
            this.sửaThôngTinToolStripMenuItem.Name = "sửaThôngTinToolStripMenuItem";
            this.sửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sửaThôngTinToolStripMenuItem.Text = "Đổi mật khẩu";
            this.sửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinToolStripMenuItem_Click);
            // 
            // tạoTàiKhoảnMớiToolStripMenuItem
            // 
            this.tạoTàiKhoảnMớiToolStripMenuItem.Name = "tạoTàiKhoảnMớiToolStripMenuItem";
            this.tạoTàiKhoảnMớiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tạoTàiKhoảnMớiToolStripMenuItem.Text = "Tạo tài khoản mới";
            this.tạoTàiKhoảnMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoTàiKhoảnMớiToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "SƠ ĐỒ BÀN ĂN";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 500);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 36);
            this.button7.TabIndex = 33;
            this.button7.Text = "Thêm";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 575);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 24);
            this.label14.TabIndex = 34;
            this.label14.Text = "CHI PHÍ PHÁT SINH";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(89, 605);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 36;
            this.button3.Text = "Nhập";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(631, 332);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 31);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_bot
            // 
            this.btn_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bot.Location = new System.Drawing.Point(631, 295);
            this.btn_bot.Name = "btn_bot";
            this.btn_bot.Size = new System.Drawing.Size(75, 31);
            this.btn_bot.TabIndex = 38;
            this.btn_bot.Text = "Bớt >>";
            this.btn_bot.UseVisualStyleBackColor = true;
            this.btn_bot.Click += new System.EventHandler(this.btn_bot_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(631, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 66);
            this.button4.TabIndex = 15;
            this.button4.Text = "Chuyển xuống bếp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(722, 259);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(274, 424);
            this.dgvMenu.TabIndex = 39;
            // 
            // flpBan
            // 
            this.flpBan.Controls.Add(this.dgvDSBAN);
            this.flpBan.Location = new System.Drawing.Point(12, 73);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(285, 421);
            this.flpBan.TabIndex = 40;
            // 
            // dgvDSBAN
            // 
            this.dgvDSBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBAN.Location = new System.Drawing.Point(3, 3);
            this.dgvDSBAN.Name = "dgvDSBAN";
            this.dgvDSBAN.Size = new System.Drawing.Size(240, 150);
            this.dgvDSBAN.TabIndex = 0;
            // 
            // chiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.flpBan);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btn_bot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "chiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chiNhanh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chiNhanh_FormClosing);
            this.Load += new System.EventHandler(this.chiNhanh_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chiNhanh_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soBan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.flpBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListView hoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPhiDichVu;
        private System.Windows.Forms.TextBox tbxGiamGia;
        private System.Windows.Forms.TextBox tbxTongCong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown soBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxLoaiHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoảnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_bot;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxTenNV;
        private System.Windows.Forms.TextBox tbxMaCN;
        private System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.DataGridView dgvDSBAN;
    }
}