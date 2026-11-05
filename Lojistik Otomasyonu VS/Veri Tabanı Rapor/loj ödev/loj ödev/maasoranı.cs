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
    public partial class maasoranı : Form
    {
        int id = -1;
        public maasoranı()
        {
            InitializeComponent();
        }
        baglan op = new baglan();
        private void personelsınıfı_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lojistikDataSet.maas_katsayı' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.maas_katsayıTableAdapter.Fill(this.lojistikDataSet.maas_katsayı);
            // TODO: Bu kod satırı 'lojistikDataSet.sınıf_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sınıf_personelTableAdapter.Fill(this.lojistikDataSet.sınıf_personel);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            op.kayıtmaas(dataGridView1,Convert.ToInt32( txtyıl.Text),float.Parse(txtoran.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            op.updatemaas(dataGridView1, Convert.ToInt32(txtyıl.Text), float.Parse(txtoran.Text), id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtoran.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtyıl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
