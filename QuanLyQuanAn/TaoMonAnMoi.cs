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
    public partial class TaoMonAnMoi : Form
    {
        DataTable dsMonAnMoi = new DataTable();

        public TaoMonAnMoi()
        {
            InitializeComponent();
        }



        private void TaoMonAnMoi_Load(object sender, EventArgs e)
        {
            txbMaCN.Text = bientoancuc.MaCNmoi;
            txbMaDM.Text = bientoancuc.MaDMmoi;
            txbTenCN.Text = bientoancuc.TenCNmoi;
            txbTenDM.Text = bientoancuc.TenDMmoi;
            txbMaMA.Text = bientoancuc.MaMAmoi;
            txbTenMA.Text = bientoancuc.TenMAmoi;
            txbDVT.Text = bientoancuc.DVTMAmoi;
            txbDonGia.Text = bientoancuc.DonGiaMAmoi;
            dsMonAnMoi = xulydulieu.docBang("select *from MonAn");

        }

        private void btnXNDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác Nhận Danh Mục");
        }

        private void btnXNMA_Click(object sender, EventArgs e)
        {
            DataRow GhiTTMonAnMoi = dsMonAnMoi.NewRow();
            GhiTTMonAnMoi["MaMonAn"] = txbMaMA.Text;
            GhiTTMonAnMoi["TenMonAn"] = txbTenMA.Text;
            GhiTTMonAnMoi["MaDanhMuc"] = txbMaDM.Text;
            GhiTTMonAnMoi["MaChiNhanh"] = txbMaCN.Text;
            GhiTTMonAnMoi["DonGia"] = txbDonGia.Text;
            GhiTTMonAnMoi["DVT"] = txbDVT.Text;

            dsMonAnMoi.Rows.Add(GhiTTMonAnMoi);
            xulydulieu.ghiBang("MonAn", dsMonAnMoi);//ghi vao bang ChiNhanh
            MessageBox.Show("Đã Thêm Món Ăn Mới!");
        }
      
    }
}
