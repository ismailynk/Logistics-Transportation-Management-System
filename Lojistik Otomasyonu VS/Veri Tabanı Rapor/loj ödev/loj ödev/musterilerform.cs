using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loj_ödev
{
    public partial class musterilerform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB-\lojistik.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;
        DataSet ds;
        int id = -1;
        baglan op = new baglan();
        public musterilerform()
        {
            //griddoldur();
            InitializeComponent();
        }
      
        private void button6_Click(object sender, EventArgs e)//kayıt etme
        {
            op.kayıtmüşteri(dataGridView1,txtad.Text,richtxtadres.Text,txttc.Text,txttel.Text,txtfrim.Text);
          
        }

        private void button7_Click(object sender, EventArgs e)//ARA
        {
            op.arama(dataGridView1, txtad.Text, "müşteri", "ad_müşteri");
        }

        private void musterilerform_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lojistikDataSet.müşteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müşteriTableAdapter.Fill(this.lojistikDataSet.müşteri);
            da = new SqlDataAdapter("select müş.*,ü.* from ürün as ü inner join müsteri_ürün as müşürün on ü.id_ürün=müşürün.id_ürün inner join müşteri as müş on müşürün.id_müsteri=müş.id_müşteri ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ürün");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)//GÜNCELLEME
        {
            op.updatemüşteri(dataGridView1, txtad.Text, richtxtadres.Text, txttc.Text, txttel.Text,txtfrim.Text,id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richtxtadres.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtfrim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
