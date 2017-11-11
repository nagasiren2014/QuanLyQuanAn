using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace QuanLyQuanAn
{
    public partial class chiNhanh : Form
    {
        int i = 0;
        int j = 1;
       
      
        public chiNhanh()
        {
            InitializeComponent();
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

        public void AddItem()
        {
            j = 1;
            hoaDon.Items.Add(dgvMenu.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            hoaDon.Items[i].SubItems.Add("1");
            hoaDon.Items[i].SubItems.Add(dgvMenu.SelectedRows[0].Cells["DVT"].Value.ToString());
            hoaDon.Items[i].SubItems.Add(dgvMenu.SelectedRows[0].Cells["DonGia"].Value.ToString());
            i++;//Tang so luong mon an (khac nhau) // Tăng số hàng
        }

        public void tongTien()
        {
            int tc = 0;
            for (int u = 0; u < i; u++)
            {
                tc = tc + int.Parse(hoaDon.Items[u].SubItems[3].Text);
                tbxTongCong.Text = (tc).ToString();
            }
            if (tc == 0)
                tbxTongCong.Text = "0";
            tc = (int.Parse(tbxTongCong.Text) + int.Parse(tbxPhiDichVu.Text));
            tbxTongCong.Text = (tc - tc * int.Parse(tbxGiamGia.Text) / 100).ToString();
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 1)
            {
                

                ListViewItem temp = new ListViewItem();

                int k;
                for (k = 0; k < i; k++)// chay tu dong 0 den dong thu i-1 
                {
                    temp = hoaDon.Items[k];
                    if (dgvMenu.SelectedRows[0].Cells["TenMonAn"].Value.ToString() == temp.Text)
                    {
                        j++;
                        hoaDon.Items[k].SubItems[1].Text = j.ToString();

                        int cost = int.Parse(dgvMenu.SelectedRows[0].Cells["DonGia"].Value.ToString()) * j;//tinh tien nhieu mon
                        hoaDon.Items[k].SubItems[3].Text = cost.ToString();
                        break;
                    }
                }
                if (k == i)
                {
                    AddItem();
                }
                tongTien();
            }
            else
                MessageBox.Show("Chọn ít hoy !");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            while (hoaDon.SelectedItems.Count > 0)
            {
                hoaDon.Items.Remove(hoaDon.SelectedItems[0]);
                i--;//giam so luong mon an (khac nhau)
            }
            tongTien();
        }



        private void btn_bot_Click(object sender, EventArgs e)
        {
            if (hoaDon.SelectedItems.Count == 1)//chi cho bot 1 lan 1 mon
            {
                int sl = int.Parse((hoaDon.SelectedItems[0].SubItems[1].Text));

                if (sl > 1)//neu so luong mon > 1
                {
                    ListViewItem temp;
                    temp = hoaDon.SelectedItems[0];
                    int dongia = 1;
                    for (int i = 0; i < dgvMenu.Rows.Count; i++)//tim don gia cua mon duoc chon ben menu
                    {
                        if (temp.Text == dgvMenu.Rows[i].Cells["TenMonAn"].Value.ToString())
                        {
                            dongia = Convert.ToInt32(dgvMenu.Rows[i].Cells["DonGia"].Value.ToString());//tim dc thi break
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
                tongTien();
            }
            else
            {
                if (hoaDon.Items.Count == 0)
                    MessageBox.Show("Có gì đâu mà bớt =='");
                else
                    if (hoaDon.SelectedItems.Count > 1)
                    MessageBox.Show("Bớt ít hoy má !");
                else
                    if (hoaDon.SelectedItems.Count == 0)
                    MessageBox.Show("Chưa chọn sao bớt :| ");
            }
        }

        private void menuCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chiNhanh_Load(object sender, EventArgs e)
        {
            bientoancuc.mn = DocBangMonAn();
            dgvMenu.DataSource = bientoancuc.mn;
           

            tbxMaNV.Text = bientoancuc.MaNV;
            tbxMaCN.Text = bientoancuc.MaCN;
            tbxTenNV.Text = bientoancuc.TenNhanVien;
            bientoancuc.mn.DefaultView.RowFilter = string.Format("MaChiNhanh LIKE '%{0}%'", tbxMaCN.Text);
        }

        public DataTable DocBangMonAn()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = bientoancuc.connectionString;
            OleDbCommand oleSelectCommand = new OleDbCommand();
            oleSelectCommand.Connection = oleConnection;
            oleSelectCommand.CommandText = "Select * From MonAn";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSelectCommand;

            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;

        }

        private void tbxPhiDichVu_TextChanged(object sender, EventArgs e)
        {
            if (tbxPhiDichVu.Text == "")
                tbxPhiDichVu.Text = "0";
            tongTien();
        }

        private void tbxGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (tbxGiamGia.Text == "")
                tbxGiamGia.Text = "0";
            tongTien();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbxSearch.Text != "")
            bientoancuc.mn.DefaultView.RowFilter = string.Format("TenMonAn LIKE '%{0}%'", tbxSearch.Text);
            else
                bientoancuc.mn.DefaultView.RowFilter = string.Format("MaChiNhanh LIKE '%{0}%'", tbxMaCN.Text);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chiNhanh_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tạoTàiKhoảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
   
}
