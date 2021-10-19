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
    public partial class musterirapor : Form
    {
        public musterirapor()
        {
            InitializeComponent();
        }

        private void musterirapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelveritabaniDataSet.musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.otelveritabaniDataSet.musteriler);

            this.reportViewer1.RefreshReport();
        }
    }
}
