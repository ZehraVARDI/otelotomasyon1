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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void btoda_Click(object sender, EventArgs e)
        {
            odarapor or = new odarapor();
            or.Show();
        }

        private void btpersonel_Click(object sender, EventArgs e)
        {
            personelraporlama pr = new personelraporlama();
            pr.Show();
        }

        private void btsikayet_Click(object sender, EventArgs e)
        {
            srapor sr = new srapor();
            sr.Show();
        }

        private void btkayit_Click(object sender, EventArgs e)
        {
            musterirapor mr = new musterirapor();
            mr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            krapor kr = new krapor();
            kr.Show();
        }

        private void Raporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa f1 = new anasayfa();
            f1.Show();
            this.Hide();
        }
    }
}
