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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            
        }



     

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            
            System.Windows.Forms.Application.Exit();
             
                
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chiNhanh cn = new chiNhanh();
            QuanLy ql = new QuanLy();
            tongDai td = new tongDai();


            if (tk.Text == "quanly")

            {
                this.Hide();
                ql.Show();
                

            }
            else
                if (tk.Text == "chinhanh")
            {
                this.Hide();
                cn.Show();
               
            }
            else if (tk.Text == "tongdai")
            {
                this.Hide();
                td.Show();
              
            }
            else

            {
                MessageBox.Show("Vui lòng nhập đúng tài khoản ! \n vd: quanly, chinhanh, tongdai", "Thông báo", MessageBoxButtons.OK);

            }



        }

        private void DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }
    }
}
