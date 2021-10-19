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
    
    public partial class sikayetler : Form
    {
        string sikayetno;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\otelveritabani.mdb");
        public sikayetler()
        {
            InitializeComponent();
        }

        private void sikayetler_Load(object sender, EventArgs e)
        {
            listele();
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

        private void btara_Click(object sender, EventArgs e)
        {
            dgsikayetler.Controls.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT *FROM sikayetler WHERE  musteritc='" + tbmusteritcara.Text + "'", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgsikayetler.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btkaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO sikayetler(musteritc,sikayet) VALUES('"+tbmusteritc.Text+"','"+tbsikayet.Text+"')",conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            listele();
        }
        void listele()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT *FROM sikayetler", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgsikayetler.Controls.Clear();
            dgsikayetler.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dgsikayetler_MouseClick(object sender, MouseEventArgs e)
        {
            sikayetno=tbno.Text = dgsikayetler.CurrentRow.Cells["sikayetno"].Value.ToString();
            tbmusteritc.Text = dgsikayetler.CurrentRow.Cells["musteritc"].Value.ToString();
            tbsikayet.Text = dgsikayetler.CurrentRow.Cells["sikayet"].Value.ToString();
            btsil.Enabled = true;
            btkaydet.Enabled = false;
            btgüncelle.Enabled = true;
        }

        private void bttemizle_Click(object sender, EventArgs e)
        {
            tbsikayet.Clear();
            tbno.Clear();
            tbmusteritc.Clear();
            btkaydet.Enabled = true;
            btgüncelle.Enabled = false;
            btsil.Enabled = false;
        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd =new OleDbCommand("UPDATE sikayetler SET musteritc='"+tbmusteritc.Text+"',sikayet='"+tbsikayet.Text+"'WHERE sikayetno="+int.Parse(sikayetno.ToString())+"",conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            listele();
        }

        private void btsil_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Silmek istediğinize eminmisiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM sikayetler WHERE sikayetno=" + int.Parse(sikayetno.ToString()) + "", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                listele();
            }
        }

        private void sikayetler_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }

      
    }
}
