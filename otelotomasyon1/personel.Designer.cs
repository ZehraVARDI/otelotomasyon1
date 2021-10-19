namespace otelotomasyon1
{
    partial class personel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            this.musteri_güncelle = new System.Windows.Forms.GroupBox();
            this.btara = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbkatno = new System.Windows.Forms.TextBox();
            this.btkapat = new System.Windows.Forms.Button();
            this.dgpersonel = new System.Windows.Forms.DataGridView();
            this.ileri = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.personel_bigileri = new System.Windows.Forms.GroupBox();
            this.tbtel = new System.Windows.Forms.MaskedTextBox();
            this.btsil = new System.Windows.Forms.Button();
            this.bttemizle = new System.Windows.Forms.Button();
            this.tbgorev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btgüncelle = new System.Windows.Forms.Button();
            this.tbkat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btkaydet = new System.Windows.Forms.Button();
            this.cbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.tbsoyad = new System.Windows.Forms.TextBox();
            this.tbad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musteri_güncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpersonel)).BeginInit();
            this.personel_bigileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteri_güncelle
            // 
            this.musteri_güncelle.BackColor = System.Drawing.Color.Transparent;
            this.musteri_güncelle.Controls.Add(this.btara);
            this.musteri_güncelle.Controls.Add(this.label8);
            this.musteri_güncelle.Controls.Add(this.tbkatno);
            this.musteri_güncelle.ForeColor = System.Drawing.Color.White;
            this.musteri_güncelle.Location = new System.Drawing.Point(146, 12);
            this.musteri_güncelle.Name = "musteri_güncelle";
            this.musteri_güncelle.Size = new System.Drawing.Size(399, 95);
            this.musteri_güncelle.TabIndex = 17;
            this.musteri_güncelle.TabStop = false;
            // 
            // btara
            // 
            this.btara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btara.BackgroundImage")));
            this.btara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btara.FlatAppearance.BorderSize = 0;
            this.btara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btara.ForeColor = System.Drawing.Color.Black;
            this.btara.Location = new System.Drawing.Point(286, 19);
            this.btara.Name = "btara";
            this.btara.Size = new System.Drawing.Size(107, 70);
            this.btara.TabIndex = 14;
            this.btara.UseVisualStyleBackColor = true;
            this.btara.Click += new System.EventHandler(this.btara_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kat No:";
            // 
            // tbkatno
            // 
            this.tbkatno.Location = new System.Drawing.Point(113, 45);
            this.tbkatno.Name = "tbkatno";
            this.tbkatno.Size = new System.Drawing.Size(142, 20);
            this.tbkatno.TabIndex = 0;
            this.tbkatno.TextChanged += new System.EventHandler(this.tbkatno_TextChanged);
            this.tbkatno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_KeyPress);
            // 
            // btkapat
            // 
            this.btkapat.BackColor = System.Drawing.Color.Transparent;
            this.btkapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btkapat.BackgroundImage")));
            this.btkapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btkapat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btkapat.FlatAppearance.BorderSize = 0;
            this.btkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btkapat.Location = new System.Drawing.Point(995, 12);
            this.btkapat.Name = "btkapat";
            this.btkapat.Size = new System.Drawing.Size(84, 65);
            this.btkapat.TabIndex = 20;
            this.btkapat.UseVisualStyleBackColor = false;
            this.btkapat.Click += new System.EventHandler(this.btkapat_Click);
            // 
            // dgpersonel
            // 
            this.dgpersonel.AllowUserToAddRows = false;
            this.dgpersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpersonel.Location = new System.Drawing.Point(12, 113);
            this.dgpersonel.Name = "dgpersonel";
            this.dgpersonel.Size = new System.Drawing.Size(842, 291);
            this.dgpersonel.TabIndex = 21;
            this.dgpersonel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgpersonel_CellMouseClick);
            // 
            // ileri
            // 
            this.ileri.BackColor = System.Drawing.Color.Transparent;
            this.ileri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ileri.BackgroundImage")));
            this.ileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ileri.Enabled = false;
            this.ileri.FlatAppearance.BorderSize = 0;
            this.ileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ileri.ForeColor = System.Drawing.Color.Black;
            this.ileri.Location = new System.Drawing.Point(407, 420);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(69, 46);
            this.ileri.TabIndex = 23;
            this.ileri.UseVisualStyleBackColor = false;
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Transparent;
            this.geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geri.BackgroundImage")));
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.FlatAppearance.BorderSize = 0;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.ForeColor = System.Drawing.Color.Black;
            this.geri.Location = new System.Drawing.Point(332, 420);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(69, 46);
            this.geri.TabIndex = 22;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // personel_bigileri
            // 
            this.personel_bigileri.BackColor = System.Drawing.Color.Transparent;
            this.personel_bigileri.Controls.Add(this.tbtel);
            this.personel_bigileri.Controls.Add(this.btsil);
            this.personel_bigileri.Controls.Add(this.bttemizle);
            this.personel_bigileri.Controls.Add(this.tbgorev);
            this.personel_bigileri.Controls.Add(this.label6);
            this.personel_bigileri.Controls.Add(this.btgüncelle);
            this.personel_bigileri.Controls.Add(this.tbkat);
            this.personel_bigileri.Controls.Add(this.label7);
            this.personel_bigileri.Controls.Add(this.btkaydet);
            this.personel_bigileri.Controls.Add(this.cbcinsiyet);
            this.personel_bigileri.Controls.Add(this.label5);
            this.personel_bigileri.Controls.Add(this.tbtc);
            this.personel_bigileri.Controls.Add(this.tbsoyad);
            this.personel_bigileri.Controls.Add(this.tbad);
            this.personel_bigileri.Controls.Add(this.label4);
            this.personel_bigileri.Controls.Add(this.label3);
            this.personel_bigileri.Controls.Add(this.label2);
            this.personel_bigileri.Controls.Add(this.label1);
            this.personel_bigileri.ForeColor = System.Drawing.Color.White;
            this.personel_bigileri.Location = new System.Drawing.Point(860, 103);
            this.personel_bigileri.Name = "personel_bigileri";
            this.personel_bigileri.Size = new System.Drawing.Size(342, 374);
            this.personel_bigileri.TabIndex = 24;
            this.personel_bigileri.TabStop = false;
            this.personel_bigileri.Text = "Personel Bilgileri";
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(105, 150);
            this.tbtel.Mask = "(999) 000-0000";
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(132, 20);
            this.tbtel.TabIndex = 29;
            // 
            // btsil
            // 
            this.btsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsil.BackgroundImage")));
            this.btsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsil.Enabled = false;
            this.btsil.FlatAppearance.BorderSize = 0;
            this.btsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsil.ForeColor = System.Drawing.Color.Black;
            this.btsil.Location = new System.Drawing.Point(250, 301);
            this.btsil.Name = "btsil";
            this.btsil.Size = new System.Drawing.Size(64, 66);
            this.btsil.TabIndex = 20;
            this.btsil.UseVisualStyleBackColor = true;
            this.btsil.Click += new System.EventHandler(this.btsil_Click);
            // 
            // bttemizle
            // 
            this.bttemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttemizle.BackgroundImage")));
            this.bttemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttemizle.Enabled = false;
            this.bttemizle.FlatAppearance.BorderSize = 0;
            this.bttemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttemizle.ForeColor = System.Drawing.Color.Black;
            this.bttemizle.Location = new System.Drawing.Point(27, 300);
            this.bttemizle.Name = "bttemizle";
            this.bttemizle.Size = new System.Drawing.Size(73, 68);
            this.bttemizle.TabIndex = 19;
            this.bttemizle.UseVisualStyleBackColor = true;
            this.bttemizle.Click += new System.EventHandler(this.bttemizle_Click);
            // 
            // tbgorev
            // 
            this.tbgorev.Location = new System.Drawing.Point(108, 232);
            this.tbgorev.Name = "tbgorev";
            this.tbgorev.Size = new System.Drawing.Size(129, 20);
            this.tbgorev.TabIndex = 18;
            this.tbgorev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Görev:";
            // 
            // btgüncelle
            // 
            this.btgüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btgüncelle.BackgroundImage")));
            this.btgüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btgüncelle.Enabled = false;
            this.btgüncelle.FlatAppearance.BorderSize = 0;
            this.btgüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btgüncelle.ForeColor = System.Drawing.Color.Black;
            this.btgüncelle.Location = new System.Drawing.Point(104, 300);
            this.btgüncelle.Name = "btgüncelle";
            this.btgüncelle.Size = new System.Drawing.Size(69, 66);
            this.btgüncelle.TabIndex = 16;
            this.btgüncelle.UseVisualStyleBackColor = true;
            this.btgüncelle.Click += new System.EventHandler(this.btgüncelle_Click);
            // 
            // tbkat
            // 
            this.tbkat.Location = new System.Drawing.Point(108, 269);
            this.tbkat.Name = "tbkat";
            this.tbkat.Size = new System.Drawing.Size(129, 20);
            this.tbkat.TabIndex = 15;
            this.tbkat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kat:";
            // 
            // btkaydet
            // 
            this.btkaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btkaydet.BackgroundImage")));
            this.btkaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btkaydet.FlatAppearance.BorderSize = 0;
            this.btkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btkaydet.ForeColor = System.Drawing.Color.Black;
            this.btkaydet.Location = new System.Drawing.Point(179, 301);
            this.btkaydet.Name = "btkaydet";
            this.btkaydet.Size = new System.Drawing.Size(65, 66);
            this.btkaydet.TabIndex = 13;
            this.btkaydet.UseVisualStyleBackColor = true;
            this.btkaydet.Click += new System.EventHandler(this.btkaydet_Click);
            // 
            // cbcinsiyet
            // 
            this.cbcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcinsiyet.FormattingEnabled = true;
            this.cbcinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.cbcinsiyet.Location = new System.Drawing.Point(108, 189);
            this.cbcinsiyet.Name = "cbcinsiyet";
            this.cbcinsiyet.Size = new System.Drawing.Size(129, 21);
            this.cbcinsiyet.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cinsiyet:";
            // 
            // tbtc
            // 
            this.tbtc.Location = new System.Drawing.Point(108, 109);
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(129, 20);
            this.tbtc.TabIndex = 7;
            this.tbtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_KeyPress);
            // 
            // tbsoyad
            // 
            this.tbsoyad.Location = new System.Drawing.Point(108, 65);
            this.tbsoyad.Name = "tbsoyad";
            this.tbsoyad.Size = new System.Drawing.Size(129, 20);
            this.tbsoyad.TabIndex = 6;
            this.tbsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // tbad
            // 
            this.tbad.Location = new System.Drawing.Point(108, 27);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(129, 20);
            this.tbad.TabIndex = 5;
            this.tbad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 478);
            this.Controls.Add(this.personel_bigileri);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.dgpersonel);
            this.Controls.Add(this.btkapat);
            this.Controls.Add(this.musteri_güncelle);
            this.Name = "personel";
            this.Text = "personel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.personel_FormClosed);
            this.Load += new System.EventHandler(this.personel_Load);
            this.musteri_güncelle.ResumeLayout(false);
            this.musteri_güncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpersonel)).EndInit();
            this.personel_bigileri.ResumeLayout(false);
            this.personel_bigileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox musteri_güncelle;
        private System.Windows.Forms.Button btara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbkatno;
        private System.Windows.Forms.Button btkapat;
        private System.Windows.Forms.DataGridView dgpersonel;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.GroupBox personel_bigileri;
        private System.Windows.Forms.TextBox tbgorev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btgüncelle;
        private System.Windows.Forms.TextBox tbkat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btkaydet;
        private System.Windows.Forms.ComboBox cbcinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.TextBox tbsoyad;
        private System.Windows.Forms.TextBox tbad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttemizle;
        private System.Windows.Forms.Button btsil;
        private System.Windows.Forms.MaskedTextBox tbtel;
    }
}