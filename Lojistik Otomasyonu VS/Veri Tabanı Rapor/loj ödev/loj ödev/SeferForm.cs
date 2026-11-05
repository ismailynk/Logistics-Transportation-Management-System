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
    public partial class SeferForm : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB-\lojistik.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;
        DataSet ds;
        public SeferForm()
        {
            InitializeComponent();
        }
        
        baglan op = new baglan();
        private void button6_Click(object sender, EventArgs e)
        {
            

            op.seferkayıt(dataGridView1, txtguzergah.Text, datebas.Value.ToShortDateString(),Convert.ToInt32( cmxarac.SelectedValue.ToString()), Convert.ToInt32(cmxsofor.SelectedValue.ToString()), Convert.ToInt32(cmxsiparis.SelectedValue.ToString()), datebit.Value.ToShortDateString(), Convert.ToInt32(cmxsorumlu.SelectedValue.ToString()));
           
        }
        private void button7_Click(object sender, EventArgs e)
        {

            da = new SqlDataAdapter("select * from sefer where (bas_tarih_sefer>='"+datebas.Value.Date.ToShortDateString()+"' and bas_tarih_sefer<='"+datebit.Value.Date.ToShortDateString() + "')", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "sefer");
            dataGridView1.DataSource = ds.Tables["sefer"];
            con.Close();
        }

        private void SeferForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lojistikDataSet.personell' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellTableAdapter.Fill(this.lojistikDataSet.personell);
            // TODO: Bu kod satırı 'lojistikDataSet.arac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aracTableAdapter.Fill(this.lojistikDataSet.arac);
            // TODO: Bu kod satırı 'lojistikDataSet.sefer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seferTableAdapter.Fill(this.lojistikDataSet.sefer);

            
            op.cmxbagla(cmxsofor, "select * from personell inner join personel_bilgi on personell.personel_bilgi = personel_bilgi.id_personel_bilgi where personel_bilgi.id_Sınıf=2", "personel", "kmlkno_personel", "id_personel");
            op.cmxbagla(cmxsorumlu, "select * from personell inner join personel_bilgi on personell.personel_bilgi = personel_bilgi.id_personel_bilgi where personel_bilgi.id_Sınıf=1", "personel", "kmlkno_personel", "id_personel");
            op.cmxbagla(cmxarac,"select*from arac","arac","plaka_arac","id_arac");
            op.cmxbagla(cmxsiparis, "select * from ürün", "ürün", "ad_ürün", "id_ürün");
        }

        

        private void soforsorguToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personellTableAdapter.soforsorgu(this.lojistikDataSet.personell);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void soforsorguToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.personellTableAdapter.soforsorgu(this.lojistikDataSet.personell);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void soforsorguToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.personellTableAdapter.soforsorgu(this.lojistikDataSet.personell);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            seferbilgi s = new seferbilgi();
           
            s.Show();
            s.setid(Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                String seferkayıtstring = "declare @sef int " +
                    "declare @arac int= "+cmxarac.SelectedValue+"" +
                    "declare @sofor int= "+cmxsofor.SelectedValue+"" +
                    "declare @sorumlu int= "+cmxsorumlu.SelectedValue+"" +
                    "declare @ürün int= "+cmxsiparis.SelectedValue+"" +
                    "declare @güzergah varchar(50) = '"+txtguzergah.Text+"'" +
                    "declare @bastar varchar(50) = '"+datebas.Value.Date.ToShortDateString()+"'" +
                    "declare @bittar varchar(50) = '"+datebit.Value.Date.ToShortDateString()+"'" +
                    "insert into sefer(guzergah_sefer, bas_tarih_sefer, id_arac, id_personel_sofor, id_sipariş, bit_tarih_sefer, sorumlu_personel) values(@güzergah, @bastar, @arac, @sofor, @ürün, @bittar, @sorumlu)" +
                    "set @sef = (select max(id_sefer)  from sefer)" +
                    "insert into arac_atama(id_arac, id_sefer)values(@arac, @sef)" +
                    "insert into atama_personel_sofor(id_sofor, id_sefer)values(@sofor, @sef)" +
                    "insert into sipariş(id_ürün, id_sefer)values(@ürün, @sef)" +
                    "insert into atama_personel_sorumlu(id_sorumlu, id_sefer)values(@sorumlu, @sef)";

                cmd.Connection = con;
                con.Open();
                cmd.CommandText = seferkayıtstring;
                cmd.ExecuteNonQuery();
                con.Close();
                op.griddoldur(dataGridView1, "sefer");
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Başarısız");
                throw;
            }
        }
    }
}
