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
    public partial class kullanicikayit : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\otelveritabani.mdb");
        public kullanicikayit()
        {
            InitializeComponent();
        }

        private void btkaydet_Click(object sender, EventArgs e)
        {
            if (tbad.Text == "" || tbsoyad.Text == "" || tbtc.Text == "" || tbtel.Text == "" || tbsf.Text == "" || tbsftekrar.Text == "" || cbcinsiyet.Text == "")
                MessageBox.Show("Eksik veri girdiniz");
            else
            {
                if (tbsf.Text.ToString() != tbsftekrar.Text.ToString())
                    MessageBox.Show("Şifre hatalı");
                else
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
                        OleDbCommand cmd = new OleDbCommand("INSERT INTO kullanici(kullaniciadi,kullanicisoyadi,kullanicitc,kullanicitel,cinsiyet,kullanicisifre) VALUES (@ad,@soyad,@tc,@tel,@cinsiyet,@sf)", conn);
                        cmd.Parameters.AddWithValue("@ad", tbad.Text);
                        cmd.Parameters.AddWithValue("@soyad", tbsoyad.Text);
                        cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                        cmd.Parameters.AddWithValue("@tel", tbtel.Text);
                        cmd.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.Text);
                        cmd.Parameters.AddWithValue("@sf", tbsf.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        DialogResult a;
                        a = MessageBox.Show("Kaydınız Yapılmıştır", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        if (a == DialogResult.OK)
                        {
                            kullanicigiris f1 = new kullanicigiris();
                            f1.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            kullanicigiris f1 = new kullanicigiris();
            f1.Show();
            this.Hide();
        }

        private void kullanicikayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            kullanicigiris f1 = new kullanicigiris();
            f1.Show();
            this.Hide();
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
    }
}
