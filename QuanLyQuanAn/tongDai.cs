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

        private void tongDai_Load(object sender, EventArgs e)
        {
            bientoancuc.BangChiNhanh = DocBangChiNhanh();
            DanhSachChiNhanh_Dgv.DataSource = bientoancuc.BangChiNhanh;
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


    }
}
