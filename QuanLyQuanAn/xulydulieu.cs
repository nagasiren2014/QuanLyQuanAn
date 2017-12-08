using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace QuanLyQuanAn
{
    class xulydulieu
    {
        //public static String connecionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QLQA;Data Source=VAIO";

        public static DataTable docBang(String sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, bientoancuc.connectionString);
            adapter.Fill(dt);
            return dt;
        }

        public static void ghiBang(String tenBang, DataTable dt)
        {
            String selectSql = "Select * from " + tenBang;
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, bientoancuc.connectionString);
            OleDbCommandBuilder buider = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }
        public static int kiemTraCot(DataTable tenBang, String tenCot, String chuoiCanTim)
        {
            for (int i = 0; i < tenBang.Rows.Count; i++)
            {
                if (tenBang.Rows[i][tenCot].ToString() == chuoiCanTim)
                    return 1;

            }
            return 0;
        }
    }
}
