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
        int i = 0;//so dong cua hoa don 
        int j = 1;//số lượng của mỗi món
        int ban;//so ban trong listview
        int dt_ban ;//mã bàn max
        int mdh;
        DataTable dsBan = new DataTable();
        DataTable ban_cost = new DataTable();
        DataTable dsBanFull = new DataTable();
        Items food = new Items();//list cac mon cua hoa don
        DataTable dsDonHang = new DataTable();
        DataTable donHangChiTiet = new DataTable();
        public chiNhanh()
        {
            InitializeComponent();
        }


        public int docMaBanMax(DataTable x)
        {
            int kq = 0;
            int max = 0;
            for (int i = 0; i < x.Rows.Count; i++)
            {
                string s = x.Rows[i]["MaBan"].ToString();
                int k = 1;
                while (k < s.Length)
                {
                    kq = kq * 10 + int.Parse(s[k].ToString());
                    k++;
                }
                if (kq > max)
                {
                    max = kq;
                }
                kq = 0;
            }
            return max;
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

        public void ghiListHoaDon()
        {
            bientoancuc.mon = new List<Items>();
            for (int i = 0; i < hoaDon.Items.Count; i++)
            {
                food = new Items();
                food.ghi(hoaDon.Items[i].Text, hoaDon.Items[i].SubItems[1].Text, hoaDon.Items[i].SubItems[2].Text, hoaDon.Items[i].SubItems[3].Text);
                bientoancuc.mon.Add(food);
            }
        }
#region HoaDon
        public void AddItem()
        {
            j = 1;
            hoaDon.Items.Add(dgvMenu.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            hoaDon.Items[i].SubItems.Add("1");
            hoaDon.Items[i].SubItems.Add(dgvMenu.SelectedRows[0].Cells["DVT"].Value.ToString());
            hoaDon.Items[i].SubItems.Add(dgvMenu.SelectedRows[0].Cells["DonGia"].Value.ToString());
            i++;//Tang so luong mon an (khac nhau) // Tăng số hàng

            
        }

        public int tongTien()
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
            tc = tc - tc * int.Parse(tbxGiamGia.Text) / 100;
            return tc;
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
                tbxTongCong.Text =  Convert.ToString(tongTien());
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
            tbxTongCong.Text =  tongTien().ToString();
           
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
               tbxTongCong.Text =  tongTien().ToString();
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
#endregion
        private void chiNhanh_Load(object sender, EventArgs e)
        {
            dsDonHang = xulydulieu.docBang("Select * From DonHang");
            mdh = dsDonHang.Rows.Count + 1;
            lb_maDH.Text = "DH" + (mdh).ToString();

            bientoancuc.mn = xulydulieu.docBang("Select * From MonAn");
            dgvMenu.DataSource = bientoancuc.mn;

            tbxMaNV.Text = bientoancuc.MaNV;
            tbxMaCN.Text = bientoancuc.MaCN;
            tbxTenNV.Text = bientoancuc.TenNhanVien;
            bientoancuc.mn.DefaultView.RowFilter = string.Format("MaChiNhanh LIKE '%{0}%'", tbxMaCN.Text);///////////////Load !
            dsBan = xulydulieu.docBang("Select * From Ban WHERE MaChiNhanh LIKE '%" + bientoancuc.MaCN + "%'");
            ban_cost = xulydulieu.docBang("Select * from TongTien");
                  
            ban = 0; // so dong cua listview
            for (int b = 0; b < dsBan.Rows.Count; b++)//doc ds ban
            {
                if (dsBan.Rows[b]["MaChiNhanh"].ToString() == bientoancuc.MaCN)
                {
                    listView_DSBAN.Items.Add(dsBan.Rows[b]["MaBan"].ToString());

                    listView_DSBAN.Items[ban].SubItems.Add(dsBan.Rows[b]["TrangThai"].ToString());
                    for (int j = 0; j < ban_cost.Rows.Count; j++)
                    {
                        if (ban_cost.Rows[j]["MaBan"].ToString() == dsBan.Rows[b]["MaBan"].ToString())
                        {
                            listView_DSBAN.Items[ban].SubItems.Add(ban_cost.Rows[j]["TongTien"].ToString());
                            break;
                        }
                    }
                    if (j == 1)

                        listView_DSBAN.Items[ban].SubItems.Add("0");


                    ban++;



                }
            }

        }

        private void tbxPhiDichVu_TextChanged(object sender, EventArgs e)
        {
            if (tbxPhiDichVu.Text == "")
                tbxPhiDichVu.Text = "0";
            //tbxTongCong.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0,15:N0}", tongTien());
            tbxTongCong.Text = tongTien().ToString();
        }

        private void tbxGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (tbxGiamGia.Text == "")
                tbxGiamGia.Text = "0";
            tbxTongCong.Text =  tongTien().ToString();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "")
            {
                bientoancuc.mn.DefaultView.RowFilter = string.Format("TenMonAn LIKE '%{0}%' AND MaChiNhanh LIKE  '%{1}%'", tbxSearch.Text, tbxMaCN);

                bientoancuc.mn.DefaultView.RowFilter = string.Format("TenMonAn LIKE '%{0}%' AND MaChiNhanh LIKE '%{1}%'", tbxSearch.Text, tbxMaCN.Text);
            }
            else
                bientoancuc.mn.DefaultView.RowFilter = string.Format("MaChiNhanh LIKE '%{0}%'", tbxMaCN.Text);

        }



        private void btn_xuongBep_Click(object sender, EventArgs e)
        {
            ghiListHoaDon();
            
           

            DataRow donHang = dsDonHang.NewRow();//////
            donHang["MaDonHang"] = lb_maDH.Text;
            donHang["MaChiNhanh"] = tbxMaCN.Text;
            donHang["ThoiDiem"] = dtp.Text;
            donHang["TrangThai"] = "Chưa thanh toán !";
            donHang["MaBan"] = listView_DSBAN.SelectedItems[0].Text;
            donHang["Loai"] = cbxLoaiHoaDon.Text;
            donHang["TongTienDonHang"] = tbxTongCong.Text;
            donHang["SDT"] = tbxSDT.Text;
           
            dsDonHang.Rows.Add(donHang);
            xulydulieu.ghiBang("DonHang", dsDonHang);//DonHang

            dsBanFull = xulydulieu.docBang("Select * From Ban");
            donHangChiTiet = xulydulieu.docBang("Select * From DonHangChiTiet");
           
            for (int k = 0; k < bientoancuc.mon.Count; k++)
            {
                DataRow dhct = donHangChiTiet.NewRow();
                dhct["MaDonHang"] = lb_maDH.Text;
                dhct["TenMonAn"] = bientoancuc.mon[k].xuatTen();
                dhct["SoLuong"] = bientoancuc.mon[k].xuatSL();
                donHangChiTiet.Rows.Add(dhct);
            }
            xulydulieu.ghiBang("DonHangChiTiet",donHangChiTiet);


            if (hoaDon.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn món !");
            }
            else
            {

                if (listView_DSBAN.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Chưa chọn bàn !");
                }
                else
                {

                    xemHoaDon hd = new xemHoaDon();
                    hd.ShowDialog();

                    if (bientoancuc.xacNhan == 1)
                    {


                        if (listView_DSBAN.SelectedItems[0].SubItems[2].Text != "0")
                        {

                            if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi hoá đơn của bàn ? ", "Coi chừng nè !! ", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                            {

                            }
                            else
                            {
                                listView_DSBAN.SelectedItems[0].SubItems[2].Text = tbxTongCong.Text;
                                for (int i = 0; i < ban_cost.Rows.Count; i++)
                                {
                                    if (ban_cost.Rows[i]["MaBan"].ToString() == listView_DSBAN.SelectedItems[0].Text)
                                    {

                                        ban_cost.Rows[i]["TongTien"] = tbxTongCong.Text;
                                        xulydulieu.ghiBang("TongTien", ban_cost);
                                        break;
                                    }
                                }


                            }
                        }
                        else
                        {
                            listView_DSBAN.SelectedItems[0].SubItems[2].Text = tbxTongCong.Text;
                            listView_DSBAN.SelectedItems[0].SubItems[1].Text = "Có Khách !";
                            DataRow cost = ban_cost.NewRow();
                            cost["MaBan"] = listView_DSBAN.SelectedItems[0].Text;
                            cost["TongTien"] = tbxTongCong.Text;

                            
                            for (int i = 0; i < dsBanFull.Rows.Count; i++)
                            {
                                if (dsBanFull.Rows[i]["MaBan"].ToString() == listView_DSBAN.SelectedItems[0].Text)
                                {

                                    dsBanFull.Rows[i]["TrangThai"] = "Có khách !";
                                    dsBanFull.Rows[i]["MaDonHang"] = lb_maDH.Text;
                                    xulydulieu.ghiBang("Ban", dsBanFull);
                                    break;
                                }
                            }

                            ban_cost.Rows.Add(cost);
                            xulydulieu.ghiBang("TongTien", ban_cost);
                           

                        }
                    }
                }
            }
            lb_maDH.Text = "DH" + (mdh + 1).ToString();
        }

        private void listView_DSBAN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {


             dsBanFull = xulydulieu.docBang("Select * From Ban");

            DataRow ban_new = dsBanFull.NewRow();

            dt_ban = docMaBanMax(dsBanFull);

            ban_new["MaBan"] = "B" + (dt_ban + 1).ToString();
            ban_new["MaChiNhanh"] = bientoancuc.MaCN;
            ban_new["TenBan"] = "Ban " + (dsBanFull.Rows.Count + 1).ToString();
            ban_new["TrangThai"] = "Trống !";

            listView_DSBAN.Items.Add(ban_new["MaBan"].ToString());
            listView_DSBAN.Items[ban].SubItems.Add("Trống !");
            listView_DSBAN.Items[ban].SubItems.Add("0");


            dsBanFull.Rows.Add(ban_new);

            xulydulieu.ghiBang("Ban",dsBanFull);
            
            ban++;
            dt_ban++;
        }

        private void listView_DSBAN_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsBanFull = xulydulieu.docBang("Select * From Ban");
            if (listView_DSBAN.SelectedItems[0].SubItems[2].Text != "0")
                {
                    MessageBox.Show("Bàn " + listView_DSBAN.SelectedItems[0].Text + " chưa thanh toán, không thể xoá !");
                }
                else
                {
                    while (listView_DSBAN.SelectedItems.Count > 0)
                    {

                        for (int i = 0; i < dsBanFull.Rows.Count; i++)
                        {
                            if (dsBanFull.Rows[i]["MaBan"].ToString() == listView_DSBAN.SelectedItems[0].Text)
                            {
                                dsBanFull.Rows[i].Delete();
                                break;
                            }
                        }

                        xulydulieu.ghiBang("Ban", dsBanFull);
                        listView_DSBAN.SelectedItems[0].Remove();
                        ban--;
                     }
                
            }
                
            
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
      

            dsDonHang = xulydulieu.docBang("Select * From DonHang WHERE MaBan LIKE '" + listView_DSBAN.SelectedItems[0].Text + "'");

            for (int d = 0; d < dsDonHang.Rows.Count; d++)
            {
                if (dsDonHang.Rows[d]["TrangThai"].ToString() == "Chưa thanh toán !")
                {
                    dsDonHang.Rows[d]["TrangThai"] = "Đã thanh toán !";
                    break;
                }
            }

            xulydulieu.ghiBang("DonHang",dsDonHang);


            dsBanFull = xulydulieu.docBang("Select * From Ban");
            for (int i = 0; i < dsBanFull.Rows.Count; i++)
            {
                if (dsBanFull.Rows[i]["MaBan"].ToString() == listView_DSBAN.SelectedItems[0].Text)
                {

                    dsBanFull.Rows[i]["TrangThai"] = "Trống !";
                    xulydulieu.ghiBang("Ban", dsBanFull);
                    break;
                }
            }
            ban_cost = xulydulieu.docBang("Select * From TongTien");
            for (int i = 0; i < ban_cost.Rows.Count; i++)
            {
                if (ban_cost.Rows[i]["MaBan"].ToString() == listView_DSBAN.SelectedItems[0].Text)
                {

                    ban_cost.Rows[i].Delete();
                    xulydulieu.ghiBang("TongTien", ban_cost);
                    break;
                }
            }
            listView_DSBAN.SelectedItems[0].SubItems[1].Text = "Trống !";
            listView_DSBAN.SelectedItems[0].SubItems[2].Text = "0";

            MessageBox.Show("Đã thanh toán !","Écccc",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tbxTongCong_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
