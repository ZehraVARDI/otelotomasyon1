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
    public partial class yataklar : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=otelveritabani.mdb");
        public static string yataknosu;
        public yataklar()
        {
            InitializeComponent();
        }

        private void yataklar_Load(object sender, EventArgs e)
        {
            yatak_olustur();

        }
        void yatak_olustur()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT odakapasite FROM odalar WHERE odaid=" + int.Parse((musteri_guncelle.oda)) + "", conn);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                int kactane = 0;
                int ust = 10;
                for (int i = 0; i < int.Parse(oku["odakapasite"].ToString()); i++)
                {
                    Button b = new Button();
                    b.Name = ((i + 1).ToString());
                    b.Text = "Yatak-" + (i + 1).ToString();
                    b.Size = new Size(80, 50);
                    if (i % 3 == 0)
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
                    b.BackColor = Color.LightBlue;
                    b.Top = ust;
                    gbyataklar.Controls.Add(b);
                    OleDbCommand cm = new OleDbCommand("SELECT yatakno FROM musteriler WHERE odaid=" + int.Parse(musteri_guncelle.oda), conn);
                    OleDbDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr["yatakno"].ToString() == (i + 1).ToString())
                            b.BackColor = Color.Red;
                    }
                    //b.Click += new EventHandler(buton_islem);//butonun click olayı.
                }
            }
            conn.Close();
        }
    }
}
