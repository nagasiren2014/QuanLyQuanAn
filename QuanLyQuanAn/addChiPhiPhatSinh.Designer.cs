namespace QuanLyQuanAn
{
    partial class addChiPhiPhatSinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSoTien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTheo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxTienNha = new System.Windows.Forms.TextBox();
            this.tbxLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelThang = new System.Windows.Forms.Panel();
            this.datetimeAdd = new System.Windows.Forms.DateTimePicker();
            this.panelThang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP CHI PHÍ PHÁT SINH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tiền:";
            // 
            // tbxSoTien
            // 
            this.tbxSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoTien.Location = new System.Drawing.Point(144, 104);
            this.tbxSoTien.Name = "tbxSoTien";
            this.tbxSoTien.Size = new System.Drawing.Size(180, 26);
            this.tbxSoTien.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "NHẬP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(303, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "HUỶ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Theo:";
            // 
            // cbbTheo
            // 
            this.cbbTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTheo.FormattingEnabled = true;
            this.cbbTheo.Items.AddRange(new object[] {
            "ngày",
            "tháng"});
            this.cbbTheo.Location = new System.Drawing.Point(67, 48);
            this.cbbTheo.Name = "cbbTheo";
            this.cbbTheo.Size = new System.Drawing.Size(64, 28);
            this.cbbTheo.TabIndex = 5;
            this.cbbTheo.SelectedIndexChanged += new System.EventHandler(this.addCBX_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tiền nhà";
            // 
            // tbxTienNha
            // 
            this.tbxTienNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTienNha.Location = new System.Drawing.Point(144, 18);
            this.tbxTienNha.Name = "tbxTienNha";
            this.tbxTienNha.Size = new System.Drawing.Size(180, 26);
            this.tbxTienNha.TabIndex = 18;
            // 
            // tbxLuong
            // 
            this.tbxLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLuong.Location = new System.Drawing.Point(144, 60);
            this.tbxLuong.Name = "tbxLuong";
            this.tbxLuong.Size = new System.Drawing.Size(180, 26);
            this.tbxLuong.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Lương nhân viên";
            // 
            // panelThang
            // 
            this.panelThang.Controls.Add(this.label9);
            this.panelThang.Controls.Add(this.tbxLuong);
            this.panelThang.Controls.Add(this.tbxTienNha);
            this.panelThang.Controls.Add(this.label10);
            this.panelThang.Location = new System.Drawing.Point(0, 136);
            this.panelThang.Name = "panelThang";
            this.panelThang.Size = new System.Drawing.Size(397, 97);
            this.panelThang.TabIndex = 21;
            // 
            // datetimeAdd
            // 
            this.datetimeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeAdd.Location = new System.Drawing.Point(144, 54);
            this.datetimeAdd.Name = "datetimeAdd";
            this.datetimeAdd.Size = new System.Drawing.Size(253, 22);
            this.datetimeAdd.TabIndex = 22;
            // 
            // addChiPhiPhatSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 295);
            this.Controls.Add(this.datetimeAdd);
            this.Controls.Add(this.panelThang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxSoTien);
            this.Controls.Add(this.cbbTheo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addChiPhiPhatSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addChiPhiPhatSinh";
            this.Load += new System.EventHandler(this.addChiPhiPhatSinh_Load);
            this.panelThang.ResumeLayout(false);
            this.panelThang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSoTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTheo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxTienNha;
        private System.Windows.Forms.TextBox tbxLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelThang;
        private System.Windows.Forms.DateTimePicker datetimeAdd;
    }
}