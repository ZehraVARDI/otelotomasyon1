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
    public partial class odarapor : Form
    {
        public odarapor()
        {
            InitializeComponent();
        }

        private void odarapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelveritabaniDataSet.odalar' table. You can move, or remove it, as needed.
            this.odalarTableAdapter.Fill(this.otelveritabaniDataSet.odalar);

            this.reportViewer1.RefreshReport();
        }
    }
}
