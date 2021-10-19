using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace otelotomasyon1
{
    public partial class personel : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\otelveritabani.mdb");
        int id;
        string eskitc, yenitc;
        public personel()
        {
            InitializeComponent();
        }

        private void btkapat_Click(object sender, EventArgs e)
        {
            kullanicigiris f1 = new kullanicigiris();
            f1.Show();
            this.Hide();
        }

        private void personel_Load(object sender, EventArgs e)
        {
            personel_listele();
        }
        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }

        private void btara_Click(object sender, EventArgs e)
        {
            dgpersonel.Controls.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT *FROM personel WHERE personelkat='" + tbkatno.Text + "'", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgpersonel.DataSource = dt;
            da.Dispose();//Bellekten atar
            conn.Close();
        }

        private void btkaydet_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand cd = new OleDbCommand("SELECT * FROM kullanici WHERE kullanicitc='" + tbtc.Text + "'", conn);
            OleDbDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Aynı TC Kimlik Numarasından Kayıt Yapamazsınız");
            }
            else
            {
                string kayit = "INSERT INTO personel(personelad,personelsoyad,personeltc,personeltel,personelcinsiyet,personelgorev,personelkat) VALUES(@ad,@soyad,@tc,@tel,@cinsiyet,@gorev,@kat)";
                veriislem(kayit);
                MessageBox.Show("Bilgiler Kaydedildi");
            }
            
        }
        void personel_listele()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT *FROM personel ", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgpersonel.DataSource = ds.Tables[0];
            da.Dispose();//bellekten atar
            conn.Close();
        }

        private void dgpersonel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = int.Parse(dgpersonel.CurrentRow.Cells["personelid"].Value.ToString());
            tbad.Text = dgpersonel.CurrentRow.Cells["personelad"].Value.ToString();
            tbsoyad.Text = dgpersonel.CurrentRow.Cells["personelsoyad"].Value.ToString();
            eskitc = tbtc.Text = dgpersonel.CurrentRow.Cells["personeltc"].Value.ToString();//şimdiki satırın şu sütununun valuesi
            tbtel.Text = dgpersonel.CurrentRow.Cells["personeltel"].Value.ToString();
            cbcinsiyet.Text = dgpersonel.CurrentRow.Cells["personelcinsiyet"].Value.ToString();
            tbgorev.Text = dgpersonel.CurrentRow.Cells["personelgorev"].Value.ToString();
            tbkat.Text = dgpersonel.CurrentRow.Cells["personelkat"].Value.ToString();
            btkaydet.Enabled = false;
            btgüncelle.Enabled = true;
            bttemizle.Enabled = true;
            btsil.Enabled = true;
        }

        private void bttemizle_Click(object sender, EventArgs e)
        {
            tbad.Clear();
            tbsoyad.Clear();
            tbtc.Clear();
            tbtel.Clear();
            tbkat.Clear();
            cbcinsiyet.Controls.Clear();
            tbgorev.Clear();
            btkaydet.Enabled = true;
            btgüncelle.Enabled = false;
            btsil.Enabled = false;
        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            yenitc = tbtc.Text;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (eskitc != yenitc)
            {
                OleDbCommand cd = new OleDbCommand("SELECT * FROM personel WHERE personeltc='" + tbtc.Text + "'", conn);
                OleDbDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tc benzersiz değil!!!");
                }
                else
                {
                    string guncelle = "UPDATE personel SET personelad=@ad,personelsoyad=@soyad,personeltc=@tc,personeltel=@tel,personelcinsiyet=@cinsiyet,personelgorev=@gorev,personelkat=@kat WHERE personelid=" + id + "";
                    veriislem(guncelle);
                    MessageBox.Show("Bilgiler Güncellendi");
                }
            }
            else
            {
                string guncelle = "UPDATE personel SET personelad=@ad,personelsoyad=@soyad,personeltc=@tc,personeltel=@tel,personelcinsiyet=@cinsiyet,personelgorev=@gorev,personelkat=@kat WHERE personelid=" + id + "";
                veriislem(guncelle);
                MessageBox.Show("Bilgiler Güncellendi");
            }
           
        }
        private void btsil_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Silmek istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM personel WHERE personelid=" + id + "", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                personel_listele();
            }
        }

        private void personel_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }

        void veriislem(string komut)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand cmd = new OleDbCommand(komut, conn);
            cmd.Parameters.AddWithValue("@ad", tbad.Text);
            cmd.Parameters.AddWithValue("@soyad", tbsoyad.Text);
            cmd.Parameters.AddWithValue("@tc", tbtc.Text);
            cmd.Parameters.AddWithValue("@tel", tbtel.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.Text);
            cmd.Parameters.AddWithValue("@gorev", tbgorev.Text);
            cmd.Parameters.AddWithValue("@kat", tbkat.Text);
            cmd.ExecuteNonQuery();
            dgpersonel.Controls.Clear();
            conn.Close();
            personel_listele();
        }
        private void tbkatno_TextChanged(object sender, EventArgs e)
        {
            string ara = "SELECT *FROM personel WHERE personelkat like '" + tbkatno.Text + "'";
            dgpersonel.Controls.Clear();
            if (conn.State == conn.State)
                conn.Open();
            OleDbCommand cmd = new OleDbCommand(ara, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgpersonel.DataSource = dt;
            da.Dispose();//Bellekten atar
            conn.Close();
        }

       


    }
}