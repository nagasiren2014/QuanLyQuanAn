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
    public partial class doiMK : Form
    {
        public doiMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxMKHT.Text == bientoancuc.MK)
            {
                if (tbxMKM.Text != tbxXNMK.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu mới không đúng !", "!", MessageBoxButtons.OK);
                }
                else
                {
                    bientoancuc.dsNhanVien.Rows[bientoancuc.viTriTK]["MatKhau"] = tbxMKM.Text;
                    xulydulieu.ghiBang("NhanVien", bientoancuc.dsNhanVien);
                    bientoancuc.MK = tbxMKM.Text;
                    this.Close();

                }
            }
            else
                MessageBox.Show("Mật khẩu hiện tại không đúng ! Vui lòng nhập lại.", "!", MessageBoxButtons.OK);
        }

        private void doiMK_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void doiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
