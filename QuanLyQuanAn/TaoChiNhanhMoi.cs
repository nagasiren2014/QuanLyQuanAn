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
    public partial class TaoChiNhanhMoi : Form
    {
        DataTable dsChiNhanhMoi = new DataTable();
        DataTable dsDanhMucMoi = new DataTable();

        public TaoChiNhanhMoi()
        {
            InitializeComponent();
        }
        public void TaoMA()
        {
            TaoMonAnMoi f = new TaoMonAnMoi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnTaoMA_Click(object sender, EventArgs e)//TẠO DANH MỤC LUÔN
        {
            bientoancuc.MaCNmoi = txbMaCN.Text;
            bientoancuc.MaDMmoi = txbMaDanhMuc.Text;
            bientoancuc.TenDMmoi = txbTenDanhMuc.Text;
            DataRow GhiTTDanhMucMoi = dsDanhMucMoi.NewRow();
            GhiTTDanhMucMoi["MaDanhMuc"] = txbMaDanhMuc.Text;
            GhiTTDanhMucMoi["TenDanhMuc"] = txbTenDanhMuc.Text;
            GhiTTDanhMucMoi["MaChiNhanh"] = txbMaCN.Text;

            dsDanhMucMoi.Rows.Add(GhiTTDanhMucMoi);
            xulydulieu.ghiBang("DanhMuc", dsDanhMucMoi);//ghi vao bang ChiNhanh
            MessageBox.Show("Đã Thêm Danh Mục Mới!\nMã Danh Mục: " + bientoancuc.MaDMmoi + "\nTên Danh Mục: " + bientoancuc.TenDMmoi+"\n");
            TaoMA();
        }

        private void btnTaoThemDM_Click(object sender, EventArgs e)
        {
            txbMaDanhMuc.Text = "";
            txbTenDanhMuc.Text = "";
        }

        private void TaoChiNhanhMoi_Load(object sender, EventArgs e)
        {

            txbTenCN.Text = bientoancuc.TenCNmoi;
            txbSDTCN.Text = bientoancuc.SDTCNmoi;
            txbDiaChiCN.Text = bientoancuc.DiachiCNmoi;
            txbQuanCN.Text = bientoancuc.QuanCNmoi;
            dsChiNhanhMoi = xulydulieu.docBang("select *from ChiNhanh");
            dsDanhMucMoi = xulydulieu.docBang("select *from DanhMuc");

        }

        private void btnTaoChiNhanhMoi_Click(object sender, EventArgs e)
        {
            DataRow GhiTTChiNhanhMoi = dsChiNhanhMoi.NewRow();
            GhiTTChiNhanhMoi["MaChiNhanh"] = txbMaCN.Text;
            GhiTTChiNhanhMoi["TenChiNhanh"] = txbTenCN.Text;
            GhiTTChiNhanhMoi["DiaChiChiNhanh"] = txbDiaChiCN.Text;
            GhiTTChiNhanhMoi["SDTChiNhanh"] = txbSDTCN.Text;
            GhiTTChiNhanhMoi["Quan"] = txbQuanCN.Text;

            dsChiNhanhMoi.Rows.Add(GhiTTChiNhanhMoi);
            xulydulieu.ghiBang("ChiNhanh", dsChiNhanhMoi);//ghi vao bang ChiNhanh
            MessageBox.Show("Đã Thêm Chi Nhánh Mới!");
        }
    }
}
