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
    public partial class krapor : Form
    {
        public krapor()
        {
            InitializeComponent();
        }

        private void krapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelveritabaniDataSet.kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.otelveritabaniDataSet.kullanici);

            this.reportViewer1.RefreshReport();
        }
    }
}
