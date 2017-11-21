using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanAn
{
    class bientoancuc
    {
        public static DataTable dsNhanVien;
        public static DataTable dsChiNhanh;
        public static string  MaNV, TenNhanVien, MaCN,MK;
        public static DataTable BangChiNhanh;
        public static DataTable BangMonAn;
        public static DataTable mn;
        public static int viTriTK;
        public static string connectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QuanLyQuanAn_Data;Data Source=DESKTOP-Q7PSKUG";
    }

}
