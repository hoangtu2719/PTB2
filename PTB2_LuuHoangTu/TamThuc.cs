using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PTB2_LuuHoangTu
{
    class TamThuc
    {
        private double a;
        private double b;
        private double c;
        public double hesoa
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double hesob
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double hesoc
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public bool Nhap(string soa, string sob, string soc)
        {
            try
            {
                a = Double.Parse(soa);
                b = Double.Parse(sob);
                c = Double.Parse(soc);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }
        public Nghiem Giaiphuongtrinh()
        {
            Nghiem dt = new Nghiem();
            double denta;
            denta = b * b - 4 * a * c;
            if(denta == 0)
            {
                dt.LOAI = 1;
                dt.nghiemx1 = -b / 2 * a;
            }else if(denta < 0)
            {
                dt.LOAI = 0;
            }
            else
            {
                dt.LOAI = 2;
                dt.nghiemx1 = (-b + Math.Sqrt(denta)) / (2 * a);
                dt.nghiemx2 = (-b - Math.Sqrt(denta)) / (2 * a);
            }
            return dt;
        }

    }
}
