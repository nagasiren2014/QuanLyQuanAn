using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class xemHoaDon : Form
    {
        public xemHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bientoancuc.xacNhan = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bientoancuc.xacNhan = 0;
            this.Close();
        }

        private void xemHoaDon_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < bientoancuc.mon.Count; i++)
            {
                hoaDonin.Items.Add(bientoancuc.mon[i].xuatTen());
                hoaDonin.Items[i].SubItems.Add(bientoancuc.mon[i].xuatSL());
                hoaDonin.Items[i].SubItems.Add(bientoancuc.mon[i].xuatDVT());
                hoaDonin.Items[i].SubItems.Add(bientoancuc.mon[i].xuatGia());
            }
        }
    }
}
