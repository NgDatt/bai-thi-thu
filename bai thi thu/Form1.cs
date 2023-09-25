using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_thi_thu
{
    public partial class FRMMAIN : Form
    {
        public FRMMAIN()
        {
            InitializeComponent();
        }

        private void FRMMAIN_Load(object sender, EventArgs e)
        {
            string hovaten = "Nguyễn Thành Đạt";
            string mssv = "5479389438";
            string mônthi = "Lập Trình";
            string sodienthoat = "0344471362";

           lblinfo.Text = "Họ và tên : " + hovaten;
            lblinfo.Text += "\nMSSV: " + mssv;
            lblinfo.Text += "\nngaythi" + System.DateTime.Now.ToString();
           
            lblinfo.Text += "\nmonthi" + mônthi;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương Trình tiện ích", "Thông tin");
        }

        private void phươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giai_Phuong_trinh_bac2 gpt = new Giai_Phuong_trinh_bac2();
            gpt.Show(); 
        }

        private void freeFireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreeFire gpt = new FreeFire();
            gpt.Show();
        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangkymonhoc gpt = new Dangkymonhoc();
            gpt.Show();
        }
    }
}
