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
    public partial class PersonelForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB-\lojistik.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;
        DataSet ds;
        int id = -1;
        baglan op = new baglan();
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lojistikDataSet.personell' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellTableAdapter.Fill(this.lojistikDataSet.personell);
            da = new SqlDataAdapter("select per.*,maas.personel_yili,maas.yil_oranı,sınıf.maaş_pozisyon,sınıf.pozisyon_sınıf,(maas.yil_oranı*sınıf.maaş_pozisyon )as Toplam_maaş from personell as per inner join personel_bilgi as pb on per.personel_bilgi=pb.id_personel_bilgi  inner join maas_katsayı as maas on pb.id_Katsayı = maas.id_maas_katsayı inner join sınıf_personel as sınıf on pb.id_Sınıf = sınıf.id_sınıf", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personell");
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();

            da = new SqlDataAdapter("select pb.id_personel_bilgi,('Yıl= '+cast(maas.personel_yili as nvarchar)+' / Pozisyon= '+sınıf.pozisyon_sınıf) as oz from personel_bilgi as pb inner join maas_katsayı as maas on pb.id_Katsayı=maas.id_maas_katsayı inner join sınıf_personel as sınıf on pb.id_Sınıf=sınıf.id_sınıf", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personel_bilgi");
            cmxsınıf.DataSource = ds.Tables[0];
            cmxsınıf.DisplayMember =ds.Tables[0].Columns[1].ColumnName;
            cmxsınıf.ValueMember = ds.Tables[0].Columns[0].ColumnName;

            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            op.kayıtpersonel(dataGridView2,txtad.Text,txttc.Text);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            txtad.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txttc.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            cmxsınıf.SelectedValue = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            op.updatepersonel(dataGridView2, txtad.Text, txttc.Text, id, Convert.ToInt32( cmxsınıf.SelectedValue));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            op.arama(dataGridView2,txttc.Text,"personell","kmlkno_personel");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maasoranı x = new maasoranı();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelsınıf y = new personelsınıf();
            y.Show();
        }

       
    }
}
