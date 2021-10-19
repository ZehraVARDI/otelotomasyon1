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
    public partial class musteri_guncelle : Form
    {
        string eskitc, yenitc;
        string eskioda;
        int id;
        public static string oda;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=otelveritabani.mdb");
        public musteri_guncelle()
        {
            InitializeComponent();
        }

        private void btkapat_Click(object sender, EventArgs e)
        {
            kullanicigiris f1 = new kullanicigiris();
            f1.Show();
            this.Hide();
        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            if (tbad.Text == "" || tbsoyad.Text == "" || tbtc.Text == "" || tbtel.Text == "" || tboda.Text == "" || cbcinsiyet.Text == "" || dtgiristarih.Text == "" || cbyatak.Text == "")
                MessageBox.Show("Eksik veri girdiniz");
            else
            {

                yenitc = tbtc.Text;
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                OleDbCommand odadurum = new OleDbCommand("SELECT odadurum FROM odalar WHERE odaid=" + int.Parse(tboda.Text.ToString()) + "", conn);
                OleDbDataReader oku = odadurum.ExecuteReader();
                OleDbCommand eskiodadurum = new OleDbCommand("SELECT odadurum FROM odalar WHERE odaid=" + int.Parse(eskioda.ToString()) + "", conn);
                OleDbDataReader eskioku = eskiodadurum.ExecuteReader();
                if (eskitc != yenitc)
                {
                    OleDbCommand cd = new OleDbCommand("SELECT * FROM musteriler WHERE musteritc='" + tbtc.Text + "'", conn);
                    OleDbDataReader dr = cd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Tc benzersiz değil!!!");
                    }
                    else
                    {
                        
                        OleDbCommand cmd = new OleDbCommand("UPDATE musteriler SET musteriad=@ad,musterisoyad=@soyad,musteritc=@tc,musteritel=@tel,mustericinsiyet=@cinsiyet,odaid=@oda,musterigiristarih=@giristarih,yatakno=@yatak1 WHERE musteriid=" + id + "", conn);
                        cmd.Parameters.AddWithValue("@ad", tbad.Text);
                        cmd.Parameters.AddWithValue("@soyad", tbsoyad.Text);
                        cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                        cmd.Parameters.AddWithValue("@tel", tbtel.Text);
                        cmd.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.Text);
                        cmd.Parameters.AddWithValue("@oda", int.Parse(tboda.Text.ToString()));
                        cmd.Parameters.AddWithValue("@giristarih", dtgiristarih.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@yatak1", cbyatak.Text);
                       
                        if (eskioda != tboda.Text)
                        {

                            oku.Read();
                            eskioku.Read();
                                OleDbCommand cm = new OleDbCommand("UPDATE odalar SET odadurum='" + (int.Parse(oku["odadurum"].ToString()) + 1) + "' WHERE odaid=" + int.Parse(tboda.Text.ToString()) + "", conn);
                                cm.ExecuteNonQuery();
                                OleDbCommand cm3 = new OleDbCommand("UPDATE odalar SET odadurum='" + (int.Parse(eskioku["odadurum"].ToString())-1) + "' WHERE odaid=" +int.Parse(eskioda.ToString()) + "", conn);
                                cm3.ExecuteNonQuery();
                            
                           
                           
                        }
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Bilgiler Güncellendi");
                    }

                }
                else
                {
                   
                    OleDbCommand cmd = new OleDbCommand("UPDATE musteriler SET musteriad=@ad,musterisoyad=@soyad,musteritc=@tc,musteritel=@tel,mustericinsiyet=@cinsiyet,odaid=@oda,musterigiristarih=@giristarih WHERE musteriid=" + id + "", conn);
                    cmd.Parameters.AddWithValue("@ad", tbad.Text);
                    cmd.Parameters.AddWithValue("@soyad", tbsoyad.Text);
                    cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                    cmd.Parameters.AddWithValue("@tel", tbtel.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.Text);
                    cmd.Parameters.AddWithValue("@oda", int.Parse(tboda.Text.ToString()));
                    cmd.Parameters.AddWithValue("@giristarih", dtgiristarih.Value.ToShortDateString());
                    if (eskioda != tboda.Text)
                    {
                        oku.Read();
                        eskioku.Read();
                       
                        OleDbCommand cm3 = new OleDbCommand("UPDATE odalar SET odadurum='" + (int.Parse(eskioku["odadurum"].ToString()) - 1) + "' WHERE odaid=" + int.Parse(eskioda.ToString()) + "", conn);
                        cm3.ExecuteNonQuery();
                        OleDbCommand cm2 = new OleDbCommand("UPDATE odalar SET odadurum='" + (int.Parse(oku["odadurum"].ToString()) + 1) + "' WHERE odaid=" + int.Parse(tboda.Text.ToString()) + "", conn);
                        cm2.ExecuteNonQuery();
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Bilgiler Güncellendi");
                }
                string abc = "SELECT * FROM musteriler";
                musteri_listele(abc);
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }
        void musteri_listele(string komut)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand cmd = new OleDbCommand(komut, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgmusteri.DataSource = ds.Tables[0];
            da.Dispose();//bellekten atar
            conn.Close();
        }

        private void musteri_guncelle_Load(object sender, EventArgs e)
        {
            
            string liste = "SELECT *FROM  musteriler";
            musteri_listele(liste);
            buton_olustur();
        }

        private void bttemizle_Click(object sender, EventArgs e)
        {
            tbad.Clear();
            tbsoyad.Clear();
            tboda.Text = "";
            cbcinsiyet.Text = "";
            tbtc.Clear();
            tbtel.Clear();
        }

        private void dgmusteri_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(dgmusteri.CurrentRow.Cells["musteriid"].Value.ToString());
            tbad.Text = dgmusteri.CurrentRow.Cells["musteriad"].Value.ToString();
            tbsoyad.Text = dgmusteri.CurrentRow.Cells["musterisoyad"].Value.ToString();
            eskitc = tbtc.Text = dgmusteri.CurrentRow.Cells["musteritc"].Value.ToString();//şimdiki satırın şu sütununun valuesi
            tbtel.Text = dgmusteri.CurrentRow.Cells["musteritel"].Value.ToString();
            cbcinsiyet.Text = dgmusteri.CurrentRow.Cells["mustericinsiyet"].Value.ToString();
            dtgiristarih.Text = dgmusteri.CurrentRow.Cells["musterigiristarih"].Value.ToString();
            eskioda = tboda.Text = dgmusteri.CurrentRow.Cells["odaid"].Value.ToString();
            cbyatak.Text = dgmusteri.CurrentRow.Cells["yatakno"].Value.ToString();
        }

        private void btara_Click(object sender, EventArgs e)
        {
            if (rbtc.Checked)
            {
                string tc = "SELECT *FROM musteriler WHERE musteritc like '" + tbmusteri.Text + "'";
                musteri_listele(tc);
            }
            else if (rbgt.Checked)
            {
                string tarih = dateTimePicker1.Value.ToShortDateString();
                string saat = "SELECT * FROM musteriler WHERE musterigiristarih LIKE '%" + tarih + "%'";
                musteri_listele(saat);
            }
            else
            {
                string tarih = dateTimePicker1.Value.ToShortDateString();
                string saat = "SELECT * FROM musteriler WHERE mustericikistarih LIKE '%" + tarih + "%'";
                musteri_listele(saat);
            }
        }

        private void musteri_guncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
           anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }

      
        private void rbtc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtc.Checked)
            {
                dateTimePicker1.Visible = false;
                tbmusteri.Visible = true;
            }
        }

        private void rbgt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgt.Checked)
            {
                dateTimePicker1.Visible = true;
                tbmusteri.Visible = false;
            }
        }

        private void rbct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbct.Checked)
            {
                dateTimePicker1.Visible = true;
                tbmusteri.Visible = false;
            }
        }

        private void btkaydet_Click(object sender, EventArgs e)
        {
            if (tbad.Text == "" || tbsoyad.Text == "" || tbtc.Text == "" || tbtel.Text == "" || tboda.Text == "" || cbcinsiyet.Text == "" || dtgiristarih.Text == "" || cbyatak.Text=="")
                MessageBox.Show("Eksik veri girdiniz");
            else
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                OleDbCommand cd = new OleDbCommand("SELECT * FROM musteriler WHERE musteritc='" + tbtc.Text + "'", conn);
                OleDbDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Aynı TC Kimlik Numarasından Kayıt Yapamazsınız");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO musteriler(musteriad,musterisoyad,musteritc,musteritel,mustericinsiyet,odaid,musterigiristarih) VALUES (@ad,@soyad,@tc,@tel,@cinsiyet,@oda,@giristarih)", conn);
                    cmd.Parameters.AddWithValue("@ad", tbad.Text);
                    cmd.Parameters.AddWithValue("@soyad", tbsoyad.Text);
                    cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                    cmd.Parameters.AddWithValue("@tel", tbtel.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.Text);
                    cmd.Parameters.AddWithValue("@oda", int.Parse(tboda.Text.ToString()));
                    cmd.Parameters.AddWithValue("@giristarih", dtgiristarih.Value.ToShortDateString());
                    cmd.ExecuteNonQuery();
                    OleDbCommand odadurum = new OleDbCommand("SELECT odadurum FROM odalar WHERE odaid=" + int.Parse(tboda.Text.ToString()) + "", conn);
                    OleDbDataReader oku = odadurum.ExecuteReader();
                    if (oku.Read())
                    {
                        OleDbCommand cm = new OleDbCommand("UPDATE odalar SET odadurum='" +(int.Parse(oku["odadurum"].ToString())+1) +"' WHERE odaid=" + int.Parse(tboda.Text.ToString()) + "", conn);
                        cm.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("Müşteri kaydedildi");
                    string abc = "SELECT *FROM musteriler";
                    musteri_listele(abc);
                }

            }
        }
        void buton_olustur()
        {
            gbodalar.Controls.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from odalar ", conn);
            OleDbDataReader oku = cmd.ExecuteReader();
            int kactane = 0;
            int ust = 0;
            int i = 0;
            while (oku.Read())
            {
                Button b = new Button();
                b.Name = (oku["odaid"].ToString());
                b.Text = "Oda-" + oku["odaid"].ToString() + Environment.NewLine + "kapasitesi-" + oku["odakapasite"];
                b.Size = new Size(80, 50);
                if (oku["odakapasite"].ToString() == oku["odadurum"].ToString())
                {
                    b.BackColor = Color.Red;
                    b.Enabled = false;
                }
                else if (oku["odadurum"].ToString() == "0")
                    b.BackColor = Color.LightBlue;
                else
                    b.BackColor = Color.Orange;
                b.ForeColor = Color.Black;
                if (i % 8 == 0)
                {
                    kactane = 45;
                    ust += 60;
                    b.Left = kactane;
                }
                else
                {
                    kactane += 90;
                    b.Left = kactane;
                }

                b.Top = ust;

                b.Click += new EventHandler(buton_islem);//butonun click olayı.
                gbodalar.Controls.Add(b);
                i++;
            }

            conn.Close();

        }
        private void buton_islem(object sender, EventArgs e)
        {
            Button b = new Button();
            b = (Button)sender;
            tboda.Text = b.Name;
            oda = b.Name;
            yataklar f1 = new yataklar();
            f1.Show();
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
