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
    public partial class personelraporlama : Form
    {
        public personelraporlama()
        {
            InitializeComponent();
        }

        private void personelraporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelveritabaniDataSet.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.otelveritabaniDataSet.personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
