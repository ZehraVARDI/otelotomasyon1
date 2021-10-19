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
    public partial class odalar : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\otelveritabani.mdb");
        int id;
        public odalar()
        {
            InitializeComponent();
        }

        private void btkapat_Click(object sender, EventArgs e)
        {
            kullanicigiris f1 = new kullanicigiris();
            f1.Show();
            this.Hide();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }

        private void odalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btara_Click(object sender, EventArgs e)
        {
            dgodalar.Controls.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM odalar WHERE odakat=" + int.Parse(tbkatno.Text.ToString()) + "", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            dgodalar.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dgodalar_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(dgodalar.CurrentRow.Cells["odaid"].Value.ToString());
            tbodano.Text = dgodalar.CurrentRow.Cells["odaid"].Value.ToString();
            tbodakat.Text = dgodalar.CurrentRow.Cells["odakat"].Value.ToString();
            tbodakapasite.Text = dgodalar.CurrentRow.Cells["odakapasite"].Value.ToString();
            tbodadurum.Text = dgodalar.CurrentRow.Cells["odadurum"].Value.ToString();
            tbodatel.Text = dgodalar.CurrentRow.Cells["odatelefon"].Value.ToString();
            tbodaucret.Text=dgodalar.CurrentRow.Cells["odaucret"].Value.ToString();
            btgüncelle.Enabled = true;
            btsil.Enabled = true;
        }
        void listele()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT *FROM odalar", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgodalar.DataSource = ds.Tables[0];
            da.Dispose();
            conn.Close();
        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE odalar SET odakat=@kat,odakapasite=@kapasite,odadurum=@durum,odatelefon=@tel,odaucret=@ucret WHERE odaid="+id+"", conn);
            cmd.Parameters.AddWithValue("@kat", tbodakat.Text);
            cmd.Parameters.AddWithValue("@kapasite", tbodakapasite.Text);
            cmd.Parameters.AddWithValue("@durum", tbodadurum.Text);
            cmd.Parameters.AddWithValue("@tel", tbodatel.Text);
            cmd.Parameters.AddWithValue("@ucret", tbodaucret.Text);
            cmd.ExecuteNonQuery();//Geriye döndürme işlemi yapar
            conn.Close();
            dgodalar.Controls.Clear();
            listele();
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

        private void odalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }

        private void btkaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO odalar(odakat,odakapasite,odadurum,odatel,odaucret) VALUES(@kat,@kapasite,@durum,@tel,@ucret)", conn);
             cmd.Parameters.AddWithValue("@kat",int.Parse(tbodakat.Text.ToString()));
             cmd.Parameters.AddWithValue("@kapasite",int.Parse(tbodakapasite.Text.ToString()));
             cmd.Parameters.AddWithValue("@durum","bos");
             cmd.Parameters.AddWithValue("@tel",tbodatel.Text);
             cmd.Parameters.AddWithValue("@ucret",tbodaucret.Text);
             cmd.ExecuteNonQuery();
             cmd.Dispose();
             conn.Close();
             listele();
        }

        private void bttemizle_Click(object sender, EventArgs e)
        {
            tbodano.Clear();
            tbodakat.Clear();
            tbodakapasite.Clear();
            tbodadurum.Clear();
            tbodatel.Clear();
            tbodaucret.Clear();

            btkaydet.Enabled = true;
            btgüncelle.Enabled = false;
            btsil.Enabled = false;
        }

        private void btsil_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Silmek istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM odalar WHERE odaid=" + id + "", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                listele();
            }
        }

     
    }
}
