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
    public partial class AracForm : Form
    {
        baglan op = new baglan();
        int id=-1;
        public AracForm()
        {
            InitializeComponent();
        }

        private void AracForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lojistikDataSet.arac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aracTableAdapter.Fill(this.lojistikDataSet.arac);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            op.kayıtarac(dataGridView1, txtplaka.Text, txttip.Text, txtmodel.Text, txtmarka.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtplaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttip.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            op.updatearac(dataGridView1, txtplaka.Text, txttip.Text, txtmodel.Text, txtmarka.Text, id);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            op.arama(dataGridView1, txtplaka.Text, "arac", "plaka_arac");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op.griddoldur(dataGridView1, "arac");
        }
    }
}
