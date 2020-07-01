using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB2_LuuHoangTu
{
    class Nghiem
    {
        private double x1;
        private double x2;
        private double loai;
        public double nghiemx1
        {
            get
            {
                return x1;
            }
            set
            {
                x1 = value;
            }
        }
        public double nghiemx2
        {
            get
            {
                return x2;
            }
            set
            {
                x2 = value;
            }
        }
        public double LOAI
        {
            get
            {
                return loai;
            }
            set
            {
                loai = value;
            }
        }
        
        public void Xuat(TextBox txtkq)
        {
            if(loai == 0)
            {
                txtkq.Text = "Phương trình vô nghiệm";
            }
            else if(loai == 1 )
            {
                txtkq.Text = "Phương trình có nghiệm kép";
                txtkq.Text = "x = " + x1; 
            }
            else
            {
                txtkq.Text = "Phương trình có hai nghiệm phân biệt";
                txtkq.Text = "x1 = " + x1 + "x2 = " + x2;
            }
        }

    }
  

}
