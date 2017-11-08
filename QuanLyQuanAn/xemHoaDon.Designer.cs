namespace QuanLyQuanAn
{
    partial class xemHoaDon
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
            this.hoaDonin = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // hoaDonin
            // 
            this.hoaDonin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.hoaDonin.GridLines = true;
            this.hoaDonin.Location = new System.Drawing.Point(108, 40);
            this.hoaDonin.Name = "hoaDonin";
            this.hoaDonin.Size = new System.Drawing.Size(374, 321);
            this.hoaDonin.TabIndex = 0;
            this.hoaDonin.UseCompatibleStateImageBehavior = false;
            this.hoaDonin.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Món";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.Width = 36;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐVT";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 108;
            // 
            // xemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 505);
            this.Controls.Add(this.hoaDonin);
            this.Name = "xemHoaDon";
            this.Text = "xemHoaDon";
           
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView hoaDonin;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}