using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhuTungXeMay2019.Models
{
    public class Cart1
    {
        CsK23T2bEntities db = new CsK23T2bEntities();
        private int idSp1;

        public Cart1(int idSp1)
        {
            // TODO: Complete member initialization
            this.idSp1 = idSp1;
        }
        public int idSp { get; set; }
        public int tenSp { get; set; }
        public int dongia { get; set; }
        public int soluong { get; set; }
        public int tonkho { get; set; }
        public int Quantity { get; set; }
        public double thanhTien
        {
            get { return soluong * dongia; }

        }
    }
}