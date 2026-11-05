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
    public partial class UrunForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB-\lojistik.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;
        DataSet ds;
        int id = -1;
        baglan op = new baglan();
        int idmüşteri = -1;
        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lojistikDataSet.ürün' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünTableAdapter.Fill(this.lojistikDataSet.ürün);
            da = new SqlDataAdapter("select ü.*,müş.* from ürün as ü inner join müsteri_ürün as müşürün on ü.id_ürün=müşürün.id_ürün inner join müşteri as müş on müşürün.id_müsteri=müş.id_müşteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ürün");
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
            op.cmxbagla(cmxmüşteri,"select id_müşteri,frima_ad from müşteri","müşteri","frima_ad","id_müşteri");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            op.kayıturun(dataGridView2, txtad.Text, txtkg.Text, txtfiyat.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {



            op.arama(dataGridView2, txtad.Text, "ürün", "ad_ürün");
        }

        private void btnveri_Click(object sender, EventArgs e)
        {
            vericek();
        }
        public void vericek() {
            txtad.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtfiyat.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtkg.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select müşürün.id_müsteri from ürün as ü inner join müsteri_ürün as müşürün on ü.id_ürün=müşürün.id_ürün where ü.id_ürün='"+id+"'";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
             idmüşteri = Convert.ToInt32(dr[0].ToString());

            dr.Close();
            con.Close();
            cmxmüşteri.SelectedValue = idmüşteri;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            op.updateürün(dataGridView2, txtad.Text, txtkg.Text, txtfiyat.Text, id,Convert.ToInt32( cmxmüşteri.SelectedValue.ToString()),idmüşteri);
        }

        private void cmxmüşteri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = cmxmüşteri.SelectedValue.ToString();
        }
    }
}
