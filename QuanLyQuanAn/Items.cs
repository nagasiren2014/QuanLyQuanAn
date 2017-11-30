using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    class Items
    {
        public  string ten;
       public   string sl;
        public  string dvt;
        public  string dongia;


        public void ghi(string a, string b, string c, string d)
        {
            ten = a;
            sl = b;
            dvt = c;
            dongia = d;
        }
        public void changemoney(string x)
        {
            dongia = x;
        }
        public string xuatTen()
        {
            return ten;
        }
        public string xuatSL()
        {
            return sl;
        }
        public string xuatDVT()
        {
            return dvt;
        }
        public string xuatGia()
        {
            return dongia;
        }

    }
}
