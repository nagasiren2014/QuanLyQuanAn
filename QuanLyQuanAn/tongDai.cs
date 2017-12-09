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
        DataTable dsKhachHangMoi = new DataTable();
        Items food = new Items();//list cac mon cua hoa don
        int mdh;
        DataTable dsDonHang = new DataTable();
        DataTable dsDonHangChiTiet = new DataTable();

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
            TextBox TongDai_KH_SDT_TextBox = new TextBox();
            TongDai_KH_SDT_TextBox.Text = "";           
            dsLichSu = DocBangLichSuKH();
            LichSuMuaHang_Dgv.DataSource = dsLichSu;
            //----------------load bang Khach Hang--------------------------
            TongDai_KH_SDT_TextBox.Text = bientoancuc.SDT_KhachHang;
            bientoancuc.dsKhachHang = DocBangKH();
            TongDai_KH_Ten_TextBox.Text = bientoancuc.Ten_KhachHang;
            TongDai_KH_DiaChi_TextBox.Text = bientoancuc.DiaChi_KhachHang;
            TongDai_KH_TinhThanh_TextBox.Text = bientoancuc.TinhThanh_KhachHang;

            dsKhachHangMoi = xulydulieu.docBang("select *from KhachHang");
            //----------------Xu Ly Database Don Hang-------------------------
            dsDonHang = xulydulieu.docBang("Select * From DonHang");
            mdh = dsDonHang.Rows.Count + 1;
            MaHoaDon_Label.Text = "DH" + (mdh).ToString();

        }
#region DocBang
        public DataTable DocBangKH()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = bientoancuc.connectionString;
            OleDbCommand oleSelectCommand = new OleDbCommand();
            oleSelectCommand.Connection = oleConnection;
            oleSelectCommand.CommandText = "Select * From KhachHang where KhachHang.SDT like '%" + bientoancuc.SDT_KhachHang + "%'";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSelectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
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
#endregion
#region MonAn

        private void DanhSachChiNhanh_Dgv_SelectionChanged(object sender, EventArgs e)
        {
            bientoancuc.BangMonAn.DefaultView.RowFilter = string.Format("MaChiNhanh LIKE '%{0}%'", DanhSachChiNhanh_Dgv.SelectedRows[0].Cells["MaChiNhanh"].Value.ToString());
            
        }

        public void AddItem()
        {
            j = 1;
            HoaDon_ListView.Items.Add(DanhSachMonAn_dgv.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            HoaDon_ListView.Items[i].SubItems.Add("1");
            HoaDon_ListView.Items[i].SubItems.Add(DanhSachMonAn_dgv.SelectedRows[0].Cells["DVT"].Value.ToString());
            HoaDon_ListView.Items[i].SubItems.Add(DanhSachMonAn_dgv.SelectedRows[0].Cells["DonGia"].Value.ToString());
            i++;//Tang so luong mon an (khac nhau) // Tăng số hàng
        }

        public void tongTien()
        {
            int tc = 0;
            for (int u = 0; u < i; u++)
            {
                tc = tc + int.Parse(HoaDon_ListView.Items[u].SubItems[3].Text);
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
                    temp = HoaDon_ListView.Items[k];
                    if (DanhSachMonAn_dgv.SelectedRows[0].Cells["TenMonAn"].Value.ToString() == temp.Text)
                    {
                        j++;
                        HoaDon_ListView.Items[k].SubItems[1].Text = j.ToString();

                        int cost = int.Parse(DanhSachMonAn_dgv.SelectedRows[0].Cells["DonGia"].Value.ToString()) * j;//tinh tien nhieu mon
                        HoaDon_ListView.Items[k].SubItems[3].Text = cost.ToString();
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
                if (HoaDon_ListView.SelectedItems.Count == 1)//chi cho bot 1 lan 1 mon
                {
                    int sl = int.Parse((HoaDon_ListView.SelectedItems[0].SubItems[1].Text));

                    if (sl > 1)//neu so luong mon > 1
                    {
                        ListViewItem temp;
                        temp = HoaDon_ListView.SelectedItems[0];
                        int dongia = 1;
                        for (int i = 0; i < DanhSachMonAn_dgv.Rows.Count; i++)//tim don gia cua mon duoc chon ben menu
                        {
                            if (temp.Text == DanhSachMonAn_dgv.Rows[i].Cells["TenMonAn"].Value.ToString())
                            {
                                dongia = Convert.ToInt32(DanhSachMonAn_dgv.Rows[i].Cells["DonGia"].Value.ToString());//tim dc thi break
                                break;
                            }
                        }

                        HoaDon_ListView.SelectedItems[0].SubItems[1].Text = (--sl).ToString();//giam so luong

                        HoaDon_ListView.SelectedItems[0].SubItems[3].Text = (dongia * sl).ToString();//cap nhat lai don gia


                    }
                    else//neu sl mon = 1 thi xoa luon
                        while (HoaDon_ListView.SelectedItems.Count > 0)//
                        {
                            HoaDon_ListView.Items.Remove(HoaDon_ListView.SelectedItems[0]);
                            i--;

                        }
                    tongTien();
                }
                else
                {
                    if (HoaDon_ListView.Items.Count == 0)
                        MessageBox.Show("Có gì đâu mà bớt =='");
                    else
                        if (HoaDon_ListView.SelectedItems.Count > 1)
                        MessageBox.Show("Bớt ít hoy má !");
                    else
                            if (HoaDon_ListView.SelectedItems.Count == 0)
                        MessageBox.Show("Chưa chọn sao bớt :| ");
                }
            }
        }

        private void TongDai_Xoa_Button_Click(object sender, EventArgs e)
        {
            {
                while (HoaDon_ListView.SelectedItems.Count > 0)
                {
                    HoaDon_ListView.Items.Remove(HoaDon_ListView.SelectedItems[0]);
                    i--;//giam so luong mon an (khac nhau)
                }
                tongTien();
            }
        }

        private void TongDai_ChonChiNhanh_Button_Click(object sender, EventArgs e)
        {
            if (DanhSachChiNhanh_Dgv.SelectedRows.Count == 1)
            {
                TextBoxChiNhanh.Text = DanhSachChiNhanh_Dgv.SelectedRows[0].Cells["MaChiNhanh"].Value.ToString();
            }

        }

        private void TongDai_SearchMonAn_Texbox_TextChanged(object sender, EventArgs e)
        {
            if (TongDai_SearchMonAn_Texbox.Text != "")
                bientoancuc.BangMonAn.DefaultView.RowFilter = string.Format("TenMonAn LIKE '%{0}%' AND MaChiNhanh LIKE '%{1}%'", TongDai_SearchMonAn_Texbox.Text, TextBoxChiNhanh.Text);
            else
                bientoancuc.BangMonAn.DefaultView.RowFilter = string.Format("MaChiNhanh LIKE '%{0}%'", TextBoxChiNhanh.Text);

        }

        #endregion MONAN
#region KhachHang
        private void TongDai_KH_SDT_TextBox_TextChanged(object sender, EventArgs e)
        {
            dsLichSu = DocBangLichSuKH();
            LichSuMuaHang_Dgv.DataSource = dsLichSu;
        }

        private void XacNhanKH_Button_Click(object sender, EventArgs e)
        {
            bientoancuc.SDT_KhachHang = TongDai_KH_SDT_TextBox.Text;
            bientoancuc.dsKhachHang = DocBangKH();
            for (int i = 0; i < bientoancuc.dsKhachHang.Rows.Count; i++)
            {
                string s = bientoancuc.dsKhachHang.Rows[i]["SDT"].ToString();
                TongDai_KH_SDT_TextBox.Text = bientoancuc.SDT_KhachHang;

                bientoancuc.Ten_KhachHang = bientoancuc.dsKhachHang.Rows[i]["TenKhachHang"].ToString();
                TongDai_KH_Ten_TextBox.Text = bientoancuc.Ten_KhachHang;

                bientoancuc.DiaChi_KhachHang = bientoancuc.dsKhachHang.Rows[i]["DiaChi"].ToString();
                TongDai_KH_DiaChi_TextBox.Text = bientoancuc.DiaChi_KhachHang;

                bientoancuc.TinhThanh_KhachHang = bientoancuc.dsKhachHang.Rows[i]["Quan"].ToString();
                TongDai_KH_TinhThanh_TextBox.Text = bientoancuc.TinhThanh_KhachHang;
            }

        }

        private void KhachCu_Button_Click(object sender, EventArgs e)
        {
            this.TongDai_KH_Ten_TextBox.ReadOnly = true;
            this.TongDai_KH_DiaChi_TextBox.ReadOnly = true;
            this.TongDai_KH_TinhThanh_TextBox.ReadOnly = true;
        }

        private void KhachMoi_Button_Click(object sender, EventArgs e)
        {
            this.TongDai_KH_Ten_TextBox.ReadOnly = false;
            this.TongDai_KH_DiaChi_TextBox.ReadOnly = false;
            this.TongDai_KH_TinhThanh_TextBox.ReadOnly = false;
            TongDai_KH_SDT_TextBox.Text = "";
            TongDai_KH_Ten_TextBox.Text = "";
            TongDai_KH_DiaChi_TextBox.Text = "";
            TongDai_KH_TinhThanh_TextBox.Text = "";
        }

        private void TaoKHMoi_Button_Click(object sender, EventArgs e)
        {
            DataRow GhiTTKhachHang = dsKhachHangMoi.NewRow();
            GhiTTKhachHang["SDT"] = TongDai_KH_SDT_TextBox.Text;
            GhiTTKhachHang["TenKhachHang"] = TongDai_KH_Ten_TextBox.Text;
            GhiTTKhachHang["DiaChi"] = TongDai_KH_DiaChi_TextBox.Text;
            GhiTTKhachHang["Quan"] = TongDai_KH_TinhThanh_TextBox.Text;

            dsKhachHangMoi.Rows.Add(GhiTTKhachHang);
            xulydulieu.ghiBang("KhachHang", dsKhachHangMoi);//ghi vao bang Khach Hang
            MessageBox.Show("Đã Thêm Khách Hàng Mới!");
            bientoancuc.dsKhachHang = DocBangKH();
        }
#endregion
        
        public void ghiListHoaDon()
        {
            bientoancuc.mon = new List<Items>();
            for (int i = 0; i < HoaDon_ListView.Items.Count; i++)
            {
                food = new Items();
                food.ghi(HoaDon_ListView.Items[i].Text, HoaDon_ListView.Items[i].SubItems[1].Text, HoaDon_ListView.Items[i].SubItems[2].Text, HoaDon_ListView.Items[i].SubItems[3].Text);
                bientoancuc.mon.Add(food);
            }
        }

        private void TongDai_XacNhan_Button_Click(object sender, EventArgs e)
        {
            ghiListHoaDon();

            DataRow donHang = dsDonHang.NewRow();
            donHang["MaDonHang"] = MaHoaDon_Label.Text;
            donHang["MaChiNhanh"] = TextBoxChiNhanh.Text;
            donHang["ThoiDiem"] = dtp.Value.ToString("yyyy/MM/dd HH:mm:ss");
            donHang["TrangThai"] = "Chưa thanh toán !";
            string str = TextBoxChiNhanh.Text.Substring(2);
                donHang["MaBan"] = "TD"+str;
            donHang["Loai"] = "TongDai";
            donHang["TongTienDonHang"] = Textbox_TongCong.Text;
            donHang["SDT"] = TongDai_KH_SDT_TextBox.Text;

            dsDonHang.Rows.Add(donHang);
            xulydulieu.ghiBang("DonHang", dsDonHang);//DonHang

            dsDonHangChiTiet = xulydulieu.docBang("Select * From DonHangChiTiet");

            for (int k = 0; k < bientoancuc.mon.Count; k++)
            {
                DataRow dhct = dsDonHangChiTiet.NewRow();
                dhct["MaDonHang"] = MaHoaDon_Label.Text;
                dhct["TenMonAn"] = bientoancuc.mon[k].xuatTen();
                dhct["SoLuong"] = bientoancuc.mon[k].xuatSL();
                dsDonHangChiTiet.Rows.Add(dhct);
            }
            xulydulieu.ghiBang("DonHangChiTiet", dsDonHangChiTiet);


            if (HoaDon_ListView.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn món !");
            }
            else
            {
                xemHoaDon hd = new xemHoaDon();
                hd.ShowDialog();
            }
            DataTable lichSuMuaHang = xulydulieu.docBang("Select * From LichSuMuaHang");
            DataRow lsmh = lichSuMuaHang.NewRow();
            lsmh["ThoiGian"] = dtp.Value.ToString("yyyy/MM/dd HH:mm:ss");
            lsmh["TongHoaDon"] = Textbox_TongCong.Text;
            lsmh["SDT"] = TongDai_KH_SDT_TextBox.Text;
            lichSuMuaHang.Rows.Add(lsmh);
            xulydulieu.ghiBang("LichSuMuaHang", lichSuMuaHang);

        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string str = TextBoxChiNhanh.Text.Substring(2);
                dsDonHang = xulydulieu.docBang("Select * From DonHang WHERE MaBan LIKE '"+ "TD"+str+"'");
            for (int d = 0; d < dsDonHang.Rows.Count; d++)
            {
                if (dsDonHang.Rows[d]["TrangThai"].ToString() == "Chưa thanh toán !")
                {
                    dsDonHang.Rows[d]["TrangThai"] = "Đã thanh toán !";
                    break;
                }
            }
            xulydulieu.ghiBang("DonHang", dsDonHang);
            MessageBox.Show("Đã Thanh Toán");
            MaHoaDon_Label.Text = "DH" + (mdh + 1).ToString();

        }
    }
}
