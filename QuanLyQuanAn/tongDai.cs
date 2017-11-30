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
    public partial class tongDai : Form
    {
        int i = 0;
        int j = 1;
        DataTable dsLichSu = new DataTable();

        #region Front
        public tongDai()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doiMK dmk = new doiMK();
            dmk.ShowDialog();
        }

        private void tongDai_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion
        private void tongDai_Load(object sender, EventArgs e)
        {
            //----------------load bang chi nhanh---------------------------
            bientoancuc.BangChiNhanh = DocBangChiNhanh();
            DanhSachChiNhanh_Dgv.DataSource = bientoancuc.BangChiNhanh;
            //----------------load bang mon an------------------------------
            bientoancuc.BangMonAn = DocBangMonAn();
            DanhSachMonAn_dgv.DataSource = bientoancuc.BangMonAn;
            DanhSachChiNhanh_Dgv.SelectionChanged += DanhSachChiNhanh_Dgv_SelectionChanged;
            //----------------load bang lich su khach hang------------------
            TongDai_KH_SDT_TextBox.Text = "";
            
            dsLichSu = DocBangLichSuKH();
            LichSuMuaHang_Dgv.DataSource = dsLichSu;

        }
        public DataTable DocBangLichSuKH()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = bientoancuc.connectionString;
            OleDbCommand oleSelectCommand = new OleDbCommand();
            oleSelectCommand.Connection = oleConnection;
            oleSelectCommand.CommandText = "Select * From LichSuMuaHang WHERE SDT LIKE '%" + TongDai_KH_SDT_TextBox.Text + "%'";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSelectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
        }

        #region MonAn

        public DataTable DocBangChiNhanh()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = bientoancuc.connectionString;
            OleDbCommand oleSelectCommand = new OleDbCommand();
            oleSelectCommand.Connection = oleConnection;
            oleSelectCommand.CommandText = "Select * From ChiNhanh";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSelectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
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

        private void DanhSachChiNhanh_Dgv_SelectionChanged(object sender, EventArgs e)
        {
            bientoancuc.BangMonAn.DefaultView.RowFilter = string.Format("MaChiNhanh LIKE '%{0}%'", DanhSachChiNhanh_Dgv.SelectedRows[0].Cells["MaChiNhanh"].Value.ToString());

        }

        public void AddItem()
        {
            j = 1;
            ListView_HoaDon.Items.Add(DanhSachMonAn_dgv.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            ListView_HoaDon.Items[i].SubItems.Add("1");
            ListView_HoaDon.Items[i].SubItems.Add(DanhSachMonAn_dgv.SelectedRows[0].Cells["DVT"].Value.ToString());
            ListView_HoaDon.Items[i].SubItems.Add(DanhSachMonAn_dgv.SelectedRows[0].Cells["DonGia"].Value.ToString());
            i++;//Tang so luong mon an (khac nhau) // Tăng số hàng
        }

        public void tongTien()
        {
            int tc = 0;
            for (int u = 0; u < i; u++)
            {
                tc = tc + int.Parse(ListView_HoaDon.Items[u].SubItems[3].Text);
                Textbox_TongCong.Text = (tc).ToString();
            }
            if (tc == 0)
                Textbox_TongCong.Text = "0";
            tc = (tc + int.Parse(TextBox_PhiDichVu.Text));
            Textbox_TongCong.Text = (tc - tc * int.Parse(TextBox_GiamGia.Text) / 100).ToString();
        }

        private void TongDai_Them_button_Click(object sender, EventArgs e)
        {
            if (DanhSachMonAn_dgv.SelectedRows.Count == 1)
            {
                ListViewItem temp = new ListViewItem();

                int k;
                for (k = 0; k < i; k++)// chay tu dong 0 den dong thu i-1 
                {
                    temp = ListView_HoaDon.Items[k];
                    if (DanhSachMonAn_dgv.SelectedRows[0].Cells["TenMonAn"].Value.ToString() == temp.Text)
                    {
                        j++;
                        ListView_HoaDon.Items[k].SubItems[1].Text = j.ToString();

                        int cost = int.Parse(DanhSachMonAn_dgv.SelectedRows[0].Cells["DonGia"].Value.ToString()) * j;//tinh tien nhieu mon
                        ListView_HoaDon.Items[k].SubItems[3].Text = cost.ToString();
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

        private void TextBox_PhiDichVu_TextChanged(object sender, EventArgs e)
        {
            tongTien();
        }

        private void TextBox_GiamGia_TextChanged(object sender, EventArgs e)
        {
            tongTien();
        }

        private void TongDai_Bot_Button_Click(object sender, EventArgs e)
        {
            {
                if (ListView_HoaDon.SelectedItems.Count == 1)//chi cho bot 1 lan 1 mon
                {
                    int sl = int.Parse((ListView_HoaDon.SelectedItems[0].SubItems[1].Text));

                    if (sl > 1)//neu so luong mon > 1
                    {
                        ListViewItem temp;
                        temp = ListView_HoaDon.SelectedItems[0];
                        int dongia = 1;
                        for (int i = 0; i < DanhSachMonAn_dgv.Rows.Count; i++)//tim don gia cua mon duoc chon ben menu
                        {
                            if (temp.Text == DanhSachMonAn_dgv.Rows[i].Cells["TenMonAn"].Value.ToString())
                            {
                                dongia = Convert.ToInt32(DanhSachMonAn_dgv.Rows[i].Cells["DonGia"].Value.ToString());//tim dc thi break
                                break;
                            }
                        }

                        ListView_HoaDon.SelectedItems[0].SubItems[1].Text = (--sl).ToString();//giam so luong

                        ListView_HoaDon.SelectedItems[0].SubItems[3].Text = (dongia * sl).ToString();//cap nhat lai don gia


                    }
                    else//neu sl mon = 1 thi xoa luon
                        while (ListView_HoaDon.SelectedItems.Count > 0)//
                        {
                            ListView_HoaDon.Items.Remove(ListView_HoaDon.SelectedItems[0]);
                            i--;

                        }
                    tongTien();
                }
                else
                {
                    if (ListView_HoaDon.Items.Count == 0)
                        MessageBox.Show("Có gì đâu mà bớt =='");
                    else
                        if (ListView_HoaDon.SelectedItems.Count > 1)
                        MessageBox.Show("Bớt ít hoy má !");
                    else
                            if (ListView_HoaDon.SelectedItems.Count == 0)
                        MessageBox.Show("Chưa chọn sao bớt :| ");
                }
            }
        }

        private void TongDai_Xoa_Button_Click(object sender, EventArgs e)
        {
            {
                while (ListView_HoaDon.SelectedItems.Count > 0)
                {
                    ListView_HoaDon.Items.Remove(ListView_HoaDon.SelectedItems[0]);
                    i--;//giam so luong mon an (khac nhau)
                }
                tongTien();
            }
        }

        private void TongDai_ChonChiNhanh_Button_Click(object sender, EventArgs e)
        {
            if (DanhSachChiNhanh_Dgv.SelectedRows.Count == 1)
            {
                TextBoxChiNhanh.Text = DanhSachChiNhanh_Dgv.SelectedRows[0].Cells["TenChiNhanh"].Value.ToString();
            }

        }
        #endregion MONAN

        private void TongDai_KH_SDT_TextBox_TextChanged(object sender, EventArgs e)
        {
            dsLichSu = DocBangLichSuKH();
            LichSuMuaHang_Dgv.DataSource = dsLichSu;
        }


    }
}
