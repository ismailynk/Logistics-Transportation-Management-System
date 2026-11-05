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
    public partial class personelsınıf : Form
    {
        baglan op = new baglan();
        public personelsınıf()
        {
            InitializeComponent();
        }
        int id = -1;

        private void personelsınıf_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lojistikDataSet.sınıf_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sınıf_personelTableAdapter.Fill(this.lojistikDataSet.sınıf_personel);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            op.kayıtpersonelsınıf(dataGridView1,txtpz.Text,Convert.ToInt32(txtmaas.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            op.updatepozisyonsınıf(dataGridView1, txtpz.Text, Convert.ToInt32(txtmaas.Text), id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtpz.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmaas.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
