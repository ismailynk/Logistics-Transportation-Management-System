using System.Data;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

public class baglan {

    public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB-\lojistik.mdf;Integrated Security=True;Connect Timeout=30");
    SqlDataAdapter da;
    DataSet ds;
    public void griddoldur(DataGridView dataGridView1,string tablename)
    {

        da = new SqlDataAdapter("Select *From "+tablename+"", con);
        ds = new DataSet();
        con.Open();
        da.Fill(ds, tablename);
        dataGridView1.DataSource = ds.Tables[tablename];
        con.Close();
    }
    public void griddoldurek(String s,DataGridView dataGridView1, string tablename)
    {

        da = new SqlDataAdapter(s, con);
        ds = new DataSet();
        con.Open();
        da.Fill(ds, tablename);
        dataGridView1.DataSource = ds.Tables[tablename];
        con.Close();
    }
    public void arama(DataGridView dg, String kelime, String tablename, String aranacakyer)
    {
        da = new SqlDataAdapter("Select *From " + tablename + " where " + aranacakyer + " like '%" + kelime + "%' ", con);
        ds = new DataSet();
        con.Open();
        da.Fill(ds, tablename);
        dg.DataSource = ds.Tables[tablename];
        con.Close();

    }


    //----------------------------------------------------------------------------------------------------------

    public void kayıtmüşteri(DataGridView dg,String ad,String adres,String tc,String tel,String fad)
        //MÜŞTERİKAYIT
    {
        try
        {
        SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "insert into müşteri(ad_müşteri,adres_müşteri,tc_müşteri," +
                "tel_müşteri,frima_ad) values ('" + ad + "','" + adres + "','" + tc + "','" + tel + "','" + fad + "')";
        cmd.ExecuteNonQuery(); 
        con.Close();
            da = new SqlDataAdapter("select ü.*,müş.* from ürün as ü inner join müsteri_ürün as müşürün on ü.id_ürün=müşürün.id_ürün inner join müşteri as müş on müşürün.id_müsteri=müş.id_müşteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ürün");
            dg.DataSource = ds.Tables[0];
            con.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }
        
    }
    public void kayıtpersonel(DataGridView dg, String ad, String tc)
        //PERSONELKAYIT
    {
        try
        {
        SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "insert into personell(ad_personel,kmlkno_personel,personel_bilgi) values ('" + ad + "','" + tc + "','" + 1 + "')";
        cmd.ExecuteNonQuery();
        con.Close();

            da = new SqlDataAdapter("select per.*,maas.personel_yili,maas.yil_oranı,sınıf.maaş_pozisyon,sınıf.pozisyon_sınıf,(maas.yil_oranı*sınıf.maaş_pozisyon )as Toplam_maaş from personell as per inner join personel_bilgi as pb on per.personel_bilgi=pb.id_personel_bilgi  inner join maas_katsayı as maas on pb.id_Katsayı = maas.id_maas_katsayı inner join sınıf_personel as sınıf on pb.id_Sınıf = sınıf.id_sınıf", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personell");
            dg.DataSource = ds.Tables[0];
            con.Close();

            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }
        
    }
    public void kayıtarac(DataGridView dg, String plaka, String tip,String model,String marka)
        //ARAÇKAYIT
    {
        try
        {
         SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "insert into arac(plaka_arac,tip_arac,model,marka) values ('" + plaka + "','" + tip + "','" + model + "','" + marka + "')";
        cmd.ExecuteNonQuery();
        con.Close();
        griddoldur(dg, "arac");

            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }
        
    }
    public void kayıturun(DataGridView dg, String ad, String kg, String fiyat)
        //ÜRÜNKAYIT
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ürün(ad_ürün,kg_ürün,fiyat_ürün) values ('" + ad + "','" + kg + "','" + fiyat + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dg, "ürün");
            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }
       
    }
    public void seferkayıt(DataGridView dg, String guzergah, String bastar, int idarac, int idsofor, int idsiparis, String bittar, int idsorumlu)
        //SEFERKAYIT
    {
        SqlCommand cmd = new SqlCommand();
        try
        {
          

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into sefer(guzergah_sefer,bas_tarih_sefer,id_arac,id_personel_sofor,id_sipariş,bit_tarih_sefer,sorumlu_personel) values ('" + guzergah + "','" + bastar + "','" + idarac + "','" + idsofor + "','" + idsiparis + "','" + bittar + "','" + idsorumlu + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dg, "sefer");
            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }
        con.Open();
        cmd.CommandText = "select max(id_sefer ) from sefer";
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int idsefer =Convert.ToInt32( dr[0].ToString());
        dr.Close();
        con.Close();
        kayıtbaglantı("arac_atama","id_arac","id_sefer",idarac,idsefer);
        kayıtbaglantı("atama_personel_sofor", "id_sofor", "id_sefer", idsofor, idsefer);
        kayıtbaglantı("atama_personel_sorumlu", "id_sorumlu", "id_sefer", idsorumlu, idsefer);
        kayıtbaglantı("sipariş", "id_ürün", "id_sefer", idsiparis, idsefer);

    }
    public void kayıtmaas(DataGridView dg, int yıl, float oran)
        //MAASKAYIT
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into maas_katsayı (personel_yili,yil_oranı) values ('" + yıl + "','" + oran + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dg, "maas_katsayı");
            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }


    }

    public void kayıtpersonelsınıf(DataGridView dg, String pozisyon, int maas) {

        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into sınıf_personel (pozisyon_sınıf,maaş_pozisyon) values ('" + pozisyon+ "','" + maas+ "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dg, "sınıf_personel");
            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }

    }

    public void kayıtbaglantı(String tablename,String v1col,String v2col,int v1,int v2)
    {

        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into "+tablename+" ("+v1col+","+v2col+") values ('" + v1+ "','" + v2+ "')";
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }

    }
    //-------------------------------------------------------------------------------------------------------------




    public void updatemüşteri(DataGridView dg, String ad, String adres, String tc, String tel, String fad,int id)
    //UPDATEMÜŞTERİ
    {

        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update müşteri set ad_müşteri=@ad,adres_müşteri=@adres,tc_müşteri=@tc,tel_müşteri=@tel,frima_ad=@frimad where id_müşteri=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@adres", adres);
            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@frimad", fad);
            
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dg, "müşteri");
            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }
    }


    public void updateürün(DataGridView dg, String ad, String kg, String fiyat,int id,int idmüş,int idtable)
        //UPDATEÜRÜN
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update ürün set ad_ürün=@ad,kg_ürün=@kg,fiyat_ürün=@fiyat  where id_ürün=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@kg", kg);
            cmd.Parameters.AddWithValue("@fiyat", fiyat);
            cmd.ExecuteNonQuery();
            con.Close();
            da = new SqlDataAdapter("select ü.*,müş.* from ürün as ü inner join müsteri_ürün as müşürün on ü.id_ürün=müşürün.id_ürün inner join müşteri as müş on müşürün.id_müsteri=müş.id_müşteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ürün");
            dg.DataSource = ds.Tables[0];
            con.Close();
            updatebaglantı("müsteri_ürün","id_ürün","id_müsteri",id,idmüş,"id_müsteriürün",idtable);
            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }
    }


    public void updatepersonel(DataGridView dg, String ad, String tc,int id,int sınıf)
        //UPDATEPERSONEL
    {

        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update personell set ad_personel=@ad,kmlkno_personel=@kmlkno,personel_bilgi=@pb where id_personel=@id ";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@kmlkno", tc);
            cmd.Parameters.AddWithValue("@pb", sınıf);
            cmd.ExecuteNonQuery();
            con.Close();

            da = new SqlDataAdapter("select per.*,maas.personel_yili,maas.yil_oranı,sınıf.maaş_pozisyon,sınıf.pozisyon_sınıf,(maas.yil_oranı*sınıf.maaş_pozisyon )as Toplam_maaş from personell as per inner join personel_bilgi as pb on per.personel_bilgi=pb.id_personel_bilgi  inner join maas_katsayı as maas on pb.id_Katsayı = maas.id_maas_katsayı inner join sınıf_personel as sınıf on pb.id_Sınıf = sınıf.id_sınıf", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personell");
            dg.DataSource = ds.Tables[0];
            con.Close();

            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }

    }

    public void updatearac(DataGridView dg, String plaka, String tip, String model, String marka,int id)
    //UPDATEARAC
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update arac set plaka_arac=@plaka,tip_arac=@tip,model=@model,marka=@marka where id_arac=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@plaka", plaka);
            cmd.Parameters.AddWithValue("@tip", tip);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@marka", marka);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dg, "arac");

            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }

    }

    public void updatemaas(DataGridView dg, int yıl,float oran, int id)
    //UPDATEMAAS
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update maas_katsayı set personel_yili=@yıl,yil_oranı=@oran where id_maas_katsayı=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@yıl", yıl);
            cmd.Parameters.AddWithValue("@oran", oran);
            
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dg, "maas_katsayı");

            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }

    }
    public void updatepozisyonsınıf(DataGridView dg, String pz, int maas, int id)
    //UPDATEPOZİSYONSINIF
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update sınıf_personel set pozisyon_sınıf=@pz,maaş_pozisyon=@mpz where id_sınıf=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pz", pz);
            cmd.Parameters.AddWithValue("@mpz", maas);

            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur(dg, "sınıf_personel");

            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }

    }
    public int tablobul(int idsefer,String tablename,String idname)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        con.Open();
        cmd.CommandText = "select "+idname+" from "+tablename+" where id_sefer='" + idsefer + "'";
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int x =Convert.ToInt32( dr[0].ToString());
        dr.Close();
        con.Close();
        return x
            ;
    }
    public void updatesefer(String guzergah, String bastar, int idarac, int idsofor, int idsiparis, String bittar, int idsorumlu,int idsefer)
        //UPDATESEFER
    {

       
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update sefer set guzergah_sefer=@gzg,bas_tarih_sefer=@bastar,id_arac=@arac,id_personel_sofor=@sofor,id_sipariş=@sipariş,bit_tarih_sefer=@bittar,sorumlu_personel=@sor where id_sefer=@id";
            cmd.Parameters.AddWithValue("@id", idsefer);
            cmd.Parameters.AddWithValue("@gzg", guzergah);
            cmd.Parameters.AddWithValue("@bastar", bastar);
            cmd.Parameters.AddWithValue("@arac", idarac);
            cmd.Parameters.AddWithValue("@sofor", idsofor);
            cmd.Parameters.AddWithValue("@sipariş", idsiparis);
            cmd.Parameters.AddWithValue("@bittar", bittar);
            cmd.Parameters.AddWithValue("@sor", idsorumlu);
            cmd.ExecuteNonQuery();
            con.Close();
            int idaracatama = tablobul(idsefer, "arac_atama", "id_atama");
            int idsoforatama = tablobul(idsefer, "atama_personel_sofor", "id_atama_sofor");
            int idsorumluatama = tablobul(idsefer, "atama_personel_sorumlu", "id_atama_sorumlu");
            int idsiparişatama = tablobul(idsefer, "sipariş", "id_sipariş");

            updatebaglantı("arac_atama", "id_arac", "id_sefer", idarac, idsefer,"id_atama",idaracatama);
            updatebaglantı("atama_personel_sofor", "id_sofor", "id_sefer", idsofor, idsefer,"id_atama_sofor",idsoforatama);
            updatebaglantı("atama_personel_sorumlu", "id_sorumlu", "id_sefer", idsorumlu, idsefer,"id_atama_sorumlu",idsorumluatama);
            updatebaglantı("sipariş", "id_ürün", "id_sefer", idsiparis, idsefer,"id_sipariş",idsiparişatama);

           
            
            

            MessageBox.Show("Kayıt Başarılı");
        

    }

    public void updatebaglantı(String tablename, String v1col, String v2col, int v1, int v2,String where,int idtabel) {
        try
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update "+tablename+" set "+v1col+"='"+v1+"',"+v2col+"='"+v2+"' where "+where+"='"+idtabel+"'";
            
           



            cmd.ExecuteNonQuery();
            con.Close();
            

            MessageBox.Show("Kayıt Başarılı");
        }
        catch (Exception)
        {
            MessageBox.Show("Kayıt Başarısız");
            throw;
        }
    }
    //--------------------------------------------------------------------------------------------

    public void cmxbagla(ComboBox cmx, String selectstring,String tabloname,String discolname,String valcolname) {
        da = new SqlDataAdapter(selectstring, con);
        ds = new DataSet();
        con.Open();
        da.Fill(ds,tabloname);
        cmx.DataSource = ds.Tables[0];
        cmx.DisplayMember =  ds.Tables[0].Columns[discolname].ColumnName;
        cmx.ValueMember = ds.Tables[0].Columns[valcolname].ColumnName;

        con.Close();


    }
}