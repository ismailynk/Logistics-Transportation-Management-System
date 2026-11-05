using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loj_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musterilerform frm = new musterilerform();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracForm arcfrm = new AracForm();
            arcfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunForm urunfrm = new UrunForm();
            urunfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelForm perfrm = new PersonelForm();
            perfrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SeferForm seffrm = new SeferForm();
            seffrm.Show();

        }
    }
}
