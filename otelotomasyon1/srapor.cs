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
    public partial class srapor : Form
    {
        public srapor()
        {
            InitializeComponent();
        }

        private void srapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelveritabaniDataSet.sikayetler' table. You can move, or remove it, as needed.
            this.sikayetlerTableAdapter.Fill(this.otelveritabaniDataSet.sikayetler);

            this.reportViewer1.RefreshReport();
        }
    }
}
