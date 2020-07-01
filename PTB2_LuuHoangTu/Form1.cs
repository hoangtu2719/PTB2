using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB2_LuuHoangTu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkq_Click(object sender, EventArgs e)
        {
            if(txta.Text == "")
            {
                MessageBox.Show("Vui long nhap so a", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtkq.Text = "";
            }
            else if(txtb.Text == "")
            {
                MessageBox.Show("Vui long nhap so b", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtkq.Text = "";
            }
            else if(txtc.Text == "")
            {
                
                MessageBox.Show("Vui long nhap so c", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtkq.Text = "";
            }
            else
            {
                TamThuc tt = new TamThuc();
                Nghiem n;
                tt.Nhap(txta.Text.Trim(), txtb.Text.Trim(), txtc.Text.Trim());
                //Hieu bien nay la mot class khac qua
                n = tt.Giaiphuongtrinh();
                n.Xuat(txtkq);
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txta.Text = txtb.Text = txtc.Text = txtkq.Text = ""; 
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
