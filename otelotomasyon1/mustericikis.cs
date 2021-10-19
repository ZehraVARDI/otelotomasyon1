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
    public partial class mustericikis : Form
    {
        int odaid;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\otelveritabani.mdb");
        int id;
        public mustericikis()
        {
            InitializeComponent();
        }
        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void geri_Click(object sender, EventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }

        private void btara_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            dttarihcikis.Enabled = true;
            btkaydet.Enabled = true;
            OleDbCommand cmd = new OleDbCommand("SELECT *FROM musteriler WHERE musteritc='" + tbmusteritc.Text + "'", conn);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                tbad.Text = oku["musteriad"].ToString();
                tbsoyad.Text = oku["musterisoyad"].ToString();
                tbodano.Text = oku["odaid"].ToString();
                odaid = int.Parse(oku["odaid"].ToString());
                dttarihgiris.Text = oku["musterigiristarih"].ToString();
            }
            else
                MessageBox.Show("Müşteri kaydı bulunamadı");
            conn.Close();
            bthesapla.Enabled = true;
        }

        private void btkaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cm = new OleDbCommand("UPDATE musteriler SET mustericikistarih='" + dttarihcikis.Value.ToShortDateString() + "' ,musteritutar=" + int.Parse(tbtutar.Text.ToString()) + " WHERE musteritc='" + tbmusteritc.Text + "'", conn);
            cm.ExecuteNonQuery();
            OleDbCommand cmd = new OleDbCommand("UPDATE odalar SET odadurum='bos' WHERE odaid="+int.Parse(tbodano.Text.ToString())+"",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Çıkış işlemi yapıldı");
        }

        private void btkapat_Click(object sender, EventArgs e)
        {
            kullanicigiris f1 = new kullanicigiris();
            f1.Show();
            this.Hide();
        }

        private void bthesapla_Click(object sender, EventArgs e)
        {
            odaid = int.Parse(tbodano.Text);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select odaucret FROM odalar WHERE odaid=" + odaid + "", conn);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                int tutar;
                DateTime bTarih = Convert.ToDateTime(dttarihcikis.Value.ToShortDateString());
                DateTime kTarih = Convert.ToDateTime(dttarihgiris.Value.ToShortDateString());
                TimeSpan Sonuc = bTarih - kTarih;
                tutar = int.Parse(oku["odaucret"].ToString()) * int.Parse(Sonuc.TotalDays.ToString());
                tbtutar.Text = tutar.ToString();
            }
            conn.Close();

        }

        private void mustericikis_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }

        private void mustericikis_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string komut = "SELECT * FROM musteriler WHERE  mustericikistarih IS  NULL";
            OleDbCommand cmd = new OleDbCommand(komut, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            btkaydet.Enabled=dttarihcikis.Enabled=bthesapla.Enabled = true;
            id = int.Parse(dataGridView1.CurrentRow.Cells["musteriid"].Value.ToString());
            tbad.Text = dataGridView1.CurrentRow.Cells["musteriad"].Value.ToString();
            tbsoyad.Text = dataGridView1.CurrentRow.Cells["musterisoyad"].Value.ToString();
            tbmusteritc.Text = dataGridView1.CurrentRow.Cells["musteritc"].Value.ToString();//şimdiki satırın şu sütununun valuesi
            tbodano.Text = dataGridView1.CurrentRow.Cells["odaid"].Value.ToString();
            dttarihgiris.Text = dataGridView1.CurrentRow.Cells["musterigiristarih"].Value.ToString();
        }

    }
}
