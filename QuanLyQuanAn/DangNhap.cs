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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            
            System.Windows.Forms.Application.Exit();
             
                
        }       
        private void DangNhap_Load(object sender, EventArgs e)
        {
            bientoancuc.dsNhanVien = DocBangNV();

        }

        public DataTable DocBangNV()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = bientoancuc.connectionString;
            OleDbCommand oleSelectCommand = new OleDbCommand();
            oleSelectCommand.Connection = oleConnection;
            oleSelectCommand.CommandText = "Select * From NhanVien";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSelectCommand;

            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;

        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           chiNhanh cn = new chiNhanh();
         
            QuanLy ql = new QuanLy();
            tongDai td = new tongDai();

            for (int i = 0; i < bientoancuc.dsNhanVien.Rows.Count; i++)
            {
                string s = bientoancuc.dsNhanVien.Rows[i]["MaNhanVien"].ToString();
                if (tk.Text == s && mk.Text == bientoancuc.dsNhanVien.Rows[i]["MatKhau"].ToString())
                {

                    if (s[0] == 'N' && s[1] == 'V')

                    {
                        
                        bientoancuc.MaNV = tk.Text;
                        bientoancuc.TenNhanVien = bientoancuc.dsNhanVien.Rows[i]["TenNhanVien"].ToString();
                        bientoancuc.MaCN = bientoancuc.dsNhanVien.Rows[i]["MaChiNhanh"].ToString();
                        bientoancuc.MK = mk.Text;
                        bientoancuc.viTriTK = i;
                        this.Hide();
                        cn.Show();
                    }
                    else
                        if (s[0] == 'Q' && s[1] == 'L')
                    {
                        this.Hide();
                        ql.Show();
                    }
                    else
                        if (s[0] == 'T' && s[1] == 'D')
                    {
                        this.Hide();
                        td.Show();
                    }
                    break;
                }
                if (i == bientoancuc.dsNhanVien.Rows.Count - 1)
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK);
            }



        }

        private void DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }

        private void tk_Click(object sender, EventArgs e)
        {
            tk.Text = "";
        }
    }
    
}
