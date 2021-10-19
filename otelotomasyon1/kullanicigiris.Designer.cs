namespace otelotomasyon1
{
    partial class kullanicigiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanicigiris));
            this.label1 = new System.Windows.Forms.Label();
            this.tbkullaniciadi = new System.Windows.Forms.TextBox();
            this.tbkullanicisf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btgiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(51, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // tbkullaniciadi
            // 
            this.tbkullaniciadi.Location = new System.Drawing.Point(168, 170);
            this.tbkullaniciadi.Name = "tbkullaniciadi";
            this.tbkullaniciadi.Size = new System.Drawing.Size(139, 20);
            this.tbkullaniciadi.TabIndex = 2;
            // 
            // tbkullanicisf
            // 
            this.tbkullanicisf.Location = new System.Drawing.Point(168, 220);
            this.tbkullanicisf.Name = "tbkullanicisf";
            this.tbkullanicisf.PasswordChar = '*';
            this.tbkullanicisf.Size = new System.Drawing.Size(139, 20);
            this.tbkullanicisf.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(51, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // btgiris
            // 
            this.btgiris.BackColor = System.Drawing.Color.Transparent;
            this.btgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btgiris.BackgroundImage")));
            this.btgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btgiris.FlatAppearance.BorderSize = 0;
            this.btgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btgiris.Location = new System.Drawing.Point(190, 264);
            this.btgiris.Name = "btgiris";
            this.btgiris.Size = new System.Drawing.Size(110, 84);
            this.btgiris.TabIndex = 5;
            this.btgiris.UseVisualStyleBackColor = false;
            this.btgiris.Click += new System.EventHandler(this.btgiris_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(112, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 131);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btkayit
            // 
            this.btkayit.BackColor = System.Drawing.Color.Transparent;
            this.btkayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btkayit.BackgroundImage")));
            this.btkayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btkayit.FlatAppearance.BorderSize = 0;
            this.btkayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btkayit.Location = new System.Drawing.Point(306, 264);
            this.btkayit.Name = "btkayit";
            this.btkayit.Size = new System.Drawing.Size(93, 84);
            this.btkayit.TabIndex = 6;
            this.btkayit.UseVisualStyleBackColor = false;
            this.btkayit.Click += new System.EventHandler(this.btkayit_Click);
            // 
            // kullanicigiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 351);
            this.Controls.Add(this.btkayit);
            this.Controls.Add(this.btgiris);
            this.Controls.Add(this.tbkullanicisf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbkullaniciadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "kullanicigiris";
            this.Text = "kullanicigiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbkullaniciadi;
        private System.Windows.Forms.TextBox tbkullanicisf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btgiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btkayit;

    }
}