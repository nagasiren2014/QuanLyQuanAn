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
using System.Data.SqlClient;

namespace QuanLyQuanAn
{
    public partial class QuanLy : Form
    {
        public string machinhanh;
        public string madanhmuc;
        DataTable dsDanhMuc = new DataTable();
        DataTable dsChiNhanh = new DataTable();
        DataTable dsMonAn = new DataTable();
        public QuanLy()
        {
            InitializeComponent();
            LoadListViewMonAn();
        }

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                System.Windows.Forms.Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            dsChiNhanh=xulydulieu.docBang("select * from ChiNhanh");
            cmbChiNhanh.DataSource = dsChiNhanh;
            cmbChiNhanh.DisplayMember = "MaChiNhanh";
            LoadListViewMonAn();

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            machinhanh = cmb.Text;
            dsDanhMuc = xulydulieu.docBang("select * from DanhMuc where MaChiNhanh like '" + machinhanh + "'");
            QuanLy_DanhMucMon_ComboBox.DataSource = dsDanhMuc;
            QuanLy_DanhMucMon_ComboBox.DisplayMember = "TenDanhMuc";

        }

        private void QuanLy_DanhMucMon_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            madanhmuc = cmb.Text;



        }
        private void LoadListViewMonAn()
        {
            bientoancuc.BangMonAn2 = xulydulieu.docBang("select MaMonAn,TenMonAn,DonGia from MonAn where MonAn.MaChiNhanh like'%" + machinhanh + "%'" + "and MonAn.MaDanhMuc like '%" + madanhmuc + "%'");
            DSMonAn_dgv.DataSource = bientoancuc.BangMonAn2;
        }

        

        public void TaoChiNhanh()
        {
            TaoChiNhanhMoi f = new TaoChiNhanhMoi() ;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnTaoChiNhanhMoi_Click(object sender, EventArgs e)
        {
            bientoancuc.SLBanCNmoi = (int)numericUpDown1.Value;
            bientoancuc.TenCNmoi=txb_TenChiNhanhMoi.Text;
            bientoancuc.SDTCNmoi = txb_DTChiNhanhMoi.Text;
            bientoancuc.DiachiCNmoi = txb_DiaChiChiNhanhMoi.Text;
            bientoancuc.QuanCNmoi = txb_QuanChiNhanhMoi.Text;
            MessageBox.Show("Tạo Chi Nhánh mới: "+ bientoancuc.TenCNmoi+"\nSDT: "+ bientoancuc.SDTCNmoi + "\nĐịa chỉ: "+ bientoancuc.DiachiCNmoi + "\nQuận: "+ bientoancuc.QuanCNmoi);

            TaoChiNhanh();
        }
    }
}
