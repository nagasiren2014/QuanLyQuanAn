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
    public partial class chiNhanh : Form
    {
        int i = 0;
        int j = 1;
        ListViewItem item;
        public chiNhanh()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã in !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLoaiHoaDon.Text == "Tại chỗ")
            {
                soBan.Enabled = true;
            }
            else
                soBan.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            showChiPhiPhatSinhmonth ps = new showChiPhiPhatSinhmonth();

            ps.ShowDialog();
            ps.Hide();




        }

        private void button3_Click(object sender, EventArgs e)
        {

            addChiPhiPhatSinh aps = new addChiPhiPhatSinh();
            aps.ShowDialog();
            aps.Hide();

        }

        private void cbxchiPhi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();

        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doiMK dmk = new doiMK();
            dmk.ShowDialog();
        }

        private void chiNhanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void AddItem(ListViewItem item )
        {
            j = 1;
            hoaDon.Items.Add(item.Text);
            hoaDon.Items[i].SubItems.Add("1");
            hoaDon.Items[i].SubItems.Add(item.SubItems[1].Text);
            hoaDon.Items[i].SubItems.Add(item.SubItems[2].Text);
            i++;//Tang so luong mon an (khac nhau) // Tang so hang
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
        
             item = menuCN.SelectedItems[0];
            ListViewItem temp = new ListViewItem() ;
           
                int k;
                for (k = 0; k < i; k++)// chay tu dong 0 den dong thu i-1 
                {
                temp = hoaDon.Items[k];
                if (item.Text == temp.Text)
                    {
                        j++;
                        hoaDon.Items[k].SubItems[1].Text = j.ToString();
         
                        int cost = int.Parse(item.SubItems[2].Text) * j;//tinh tien nhieu mon
                        hoaDon.Items[k].SubItems[3].Text = cost.ToString();       
                        break;
                    }
                }
                if (k == i)
                {
                AddItem(item);
                }
            }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            while (hoaDon.SelectedItems.Count > 0)
            {
                hoaDon.Items.Remove(hoaDon.SelectedItems[0]);
                i--;//giam so luong mon an (khac nhau)
            }
        }

      

        private void btn_bot_Click(object sender, EventArgs e)
        {
            if (hoaDon.SelectedItems.Count == 1)//chi cho bot 1 lan 1 mon
            {
                int sl = int.Parse((hoaDon.SelectedItems[0].SubItems[1].Text));

                if (sl > 1)//neu so luong mon > 1
                {
                    item = hoaDon.SelectedItems[0];
                    int dongia = 1;
                    for (int i = 0; i < menuCN.Items.Count; i++)//tim don gia cua mon duoc chon ben menu
                    {
                        if (item.Text == menuCN.Items[i].Text)
                        {
                            dongia = Convert.ToInt32(menuCN.Items[i].SubItems[2].Text);//tim dc thi break
                            break;
                        }
                    }

                    hoaDon.SelectedItems[0].SubItems[1].Text = (--sl).ToString();//giam so luong

                    hoaDon.SelectedItems[0].SubItems[3].Text = (dongia * sl).ToString();//cap nhat lai don gia


                }
                else//neu sl mon = 1 thi xoa luon
                    while (hoaDon.SelectedItems.Count > 0)//
                    {
                        hoaDon.Items.Remove(hoaDon.SelectedItems[0]);
                        i--;
                       
                    }
            }
        }

        private void menuCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chiNhanh_Load(object sender, EventArgs e)
        {

        }
    }
}
