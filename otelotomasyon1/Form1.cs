using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelotomasyon1
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void btcikis_Click(object sender, EventArgs e)
        {
            mustericikis f1 = new mustericikis();
            f1.Show();
            this.Hide();
        }

     
        private void btkapat_Click(object sender, EventArgs e)
        {
            kullanicigiris f1 = new kullanicigiris();
            f1.Show();
            this.Hide();
        }

        private void btpersonel_Click(object sender, EventArgs e)
        {
            personel f1 = new personel();
            f1.Show();
            this.Hide();
        }

        private void btoda_Click(object sender, EventArgs e)
        {
            odalar f1 = new odalar();
            f1.Show();
            this.Hide();
        }

        private void btsikayet_Click(object sender, EventArgs e)
        {
            sikayetler f1 = new sikayetler();
            f1.Show();
            this.Hide();
        }

       private void anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            kullanicigiris f1 = new kullanicigiris();
            f1.Show();
            this.Hide();
        }

       private void button1_Click(object sender, EventArgs e)
       {
           Raporlar r = new Raporlar();
           r.Show();
           this.Hide();
       }

       private void btkayit_Click(object sender, EventArgs e)
       {
           musteri_guncelle f1 = new musteri_guncelle();
           f1.Show();
           this.Hide();
       }
    }
}
