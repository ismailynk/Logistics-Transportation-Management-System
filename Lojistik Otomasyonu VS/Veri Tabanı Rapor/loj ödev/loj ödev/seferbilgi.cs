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
    public partial class seferbilgi : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB-\lojistik.mdf;Integrated Security=True;Connect Timeout=30");
       // SqlDataAdapter da;
      //  DataSet ds;
        public static int idsefer=-1;
        baglan op = new baglan();
        public seferbilgi()
        {
            InitializeComponent();
        }
        public void setid(int id) {
            idsefer = id;
            String s = "select  k.*,arac.*,ürün.*,personell.*,personell.*,p.id_personel as sid,p.kmlkno_personel as stc,p.ad_personel as sad from sefer as k inner join arac as arac on k.id_arac= arac.id_arac   inner join ürün as ürün on k.id_sipariş=ürün.id_ürün inner join  personell as personell on k.id_personel_sofor=personell.id_personel   inner join  personell as p on k.sorumlu_personel=p.id_personel where k.id_sefer= '" + idsefer + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = s;
            
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtgüzergah.Text = dr["guzergah_sefer"].ToString();
            datebas.Value =Convert.ToDateTime( dr["bas_tarih_sefer"]);
            datebit.Value = Convert.ToDateTime(dr["bit_tarih_sefer"]);
            lblplaka.Text = "Plaka = "+dr["plaka_arac"].ToString();
            lblaractip.Text = "Tip = " + dr["tip_arac"].ToString();
            lblaracmarka.Text = "Marka = " + dr["marka"].ToString();
            lblaracmdoel.Text = "Model = " + dr["model"].ToString();

            lblsoforad.Text ="sofor ad = "+ dr["ad_personel"].ToString();
            lblsofortc.Text = "sofor tc = "+dr["kmlkno_personel"].ToString();
            lblsorumluad.Text = "sorumlu ad = "+dr["sad"].ToString();
            lblsorumlutc.Text ="sorumlu tc = "+ dr["stc"].ToString();

            lblsiparişfiyat.Text ="Ürün fiyatı = "+ dr["fiyat_ürün"].ToString();
            lblsiparişkg.Text = "ürün kilosu = "+dr["kg_ürün"].ToString();
            labelürünad.Text = "ürün adı = "+dr["ad_ürün"].ToString();

            op.cmxbagla(cmxsofor, "select * from personell inner join personel_bilgi on personell.personel_bilgi = personel_bilgi.id_personel_bilgi where personel_bilgi.id_Sınıf=2", "personel", "kmlkno_personel", "id_personel");
            op.cmxbagla(cmxsorumlu, "select * from personell inner join personel_bilgi on personell.personel_bilgi = personel_bilgi.id_personel_bilgi where personel_bilgi.id_Sınıf=1", "personel", "kmlkno_personel", "id_personel");
            op.cmxbagla(cmxarac, "select*from arac", "arac", "plaka_arac", "id_arac");
            op.cmxbagla(cmxürün, "select * from ürün", "ürün", "ad_ürün", "id_ürün");
            
            dr.Close();
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            op.updatesefer(txtgüzergah.Text, datebas.Value.Date.ToShortDateString(), Convert.ToInt32(cmxarac.SelectedValue.ToString()), Convert.ToInt32(cmxsofor.SelectedValue.ToString()), Convert.ToInt32(cmxürün.SelectedValue.ToString()), datebit.Value.Date.ToShortDateString(), Convert.ToInt32(cmxsorumlu.SelectedValue.ToString()),idsefer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op.kayıtbaglantı("arac_atama","id_arac","id_sefer",Convert.ToInt32(cmxarac.SelectedValue),idsefer);
            op.kayıtbaglantı("atama_personel_sofor","id_sofor","id_sefer",Convert.ToInt32(cmxsofor.SelectedValue),idsefer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op.kayıtbaglantı("sipariş","id_ürün","id_sefer",Convert.ToInt32( cmxürün.SelectedValue),idsefer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilgigöster b = new bilgigöster();
            b.setdata("select sefer.id_sefer,arac.* from sefer inner join arac_atama on sefer.id_sefer = arac_atama.id_sefer inner join arac on arac_atama.id_arac = arac.id_arac where sefer.id_sefer ="+idsefer+"","arac_atama");
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bilgigöster b = new bilgigöster();
            b.setdata("select sefer.id_sefer,personell.* from sefer inner join atama_personel_sofor on sefer.id_sefer = atama_personel_sofor.id_sefer inner join personell on atama_personel_sofor.id_sofor = personell.id_personel where sefer.id_sefer = "+idsefer+"","atama_personel_sofor");
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bilgigöster b = new bilgigöster();
            b.setdata("select sefer.id_sefer,ürün.* from sefer inner join sipariş on sefer.id_sefer = sipariş.id_sefer inner join ürün on sipariş.id_ürün = ürün.id_ürün where sefer.id_sefer = "+idsefer+"","sipariş");
            b.Show();
        }
    }
}
