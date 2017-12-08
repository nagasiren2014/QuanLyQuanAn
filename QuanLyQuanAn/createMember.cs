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
    public partial class createMember : Form
    {
        public createMember()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable KhachHang = xulydulieu.docBang("Select * From KhachHang");
            DataRow kh = KhachHang.NewRow();
            kh["SDT"] = tbxSDT.Text;
            kh["TenKhachHang"] = tbxTen.Text;
            kh["DiaChi"] = tbxDiaChi.Text;
            kh["Quan"] = cbbQuan.Text;
            KhachHang.Rows.Add(kh);
            xulydulieu.ghiBang("KhachHang",KhachHang);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createMember_Load(object sender, EventArgs e)
        {
            tbxSDT.Text = bientoancuc.SDT_KhachHang;
        }
    }
}
