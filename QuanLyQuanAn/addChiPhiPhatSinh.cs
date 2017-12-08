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
    public partial class addChiPhiPhatSinh : Form
    {
        public addChiPhiPhatSinh()
        {
            InitializeComponent();
        }

        DataTable chiPhiNgay;
        DataTable chiPhiThang;

        private void addCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTheo.Text == "ngày")
            {
                
                panelThang.Enabled = false;
                tbxSoTien.Enabled = true;

            }
            else
            {
                
                panelThang.Enabled = true;
                tbxSoTien.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbTheo.Text == "ngày")
            {
                chiPhiNgay = xulydulieu.docBang("Select * From ChiPhiNgay");
                DataRow cpn = chiPhiNgay.NewRow();
                cpn["MaChiNhanh"] = bientoancuc.MaCN;
                cpn["ThoiGianNhap"] = datetimeAdd.Text;
                cpn["SoTien"] = tbxSoTien.Text;
                chiPhiNgay.Rows.Add(cpn);
                xulydulieu.ghiBang("ChiPhiNgay", chiPhiNgay);
            }
            else
            if(cbbTheo.Text == "tháng")
            {
                chiPhiThang = xulydulieu.docBang("Select * From ChiPhiThang");
                DataRow cpt = chiPhiThang.NewRow();
                cpt["MaChiNhanh"] = bientoancuc.MaCN;
                cpt["ThoiGianNhap"] = datetimeAdd.Text;
                cpt["LuongNhanVien"] = tbxLuong.Text;
                cpt["TienNha"] = tbxTienNha.Text;
                chiPhiThang.Rows.Add(cpt);
                xulydulieu.ghiBang("ChiPhiThang", chiPhiThang);
            }
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addChiPhiPhatSinh_Load(object sender, EventArgs e)
        {
            tbxSoTien.Enabled = false;
            panelThang.Enabled = false;
        }
    }
}
