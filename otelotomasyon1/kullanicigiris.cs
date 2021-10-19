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
    public partial class kullanicigiris : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\otelveritabani.mdb");//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\CASPER\Documents\otelveritabani.mdb
        public kullanicigiris()
        {
            InitializeComponent();  
        }

        private void btgiris_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT *FROM kullanici WHERE kullaniciadi='"+ tbkullaniciadi.Text +"' AND kullanicisifre='"+ tbkullanicisf.Text +"'",conn);
            cmd.Connection = conn;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                anasayfa f1 = new anasayfa();
                f1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Yanlış kullanıcı adı ya da şifre");
            conn.Close();
        }

        private void btkayit_Click(object sender, EventArgs e)
        {
            kullanicikayit f1 = new kullanicikayit();
            f1.Show();
            this.Hide();
        }
    }
}
