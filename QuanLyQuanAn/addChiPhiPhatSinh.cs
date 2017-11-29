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
    public partial class addChiPhiPhatSinh : Form
    {
        public addChiPhiPhatSinh()
        {
            InitializeComponent();
        }

        private void addCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addCBX.Text == "ngày")
            {
                
                panelThang.Enabled = false;
                soTientbx.Enabled = true;

            }
            else
            {
                
                panelThang.Enabled = true;
                soTientbx.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
