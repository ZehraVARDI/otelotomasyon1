namespace otelotomasyon1
{
    partial class yataklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yataklar));
            this.gbyataklar = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbyataklar
            // 
            this.gbyataklar.BackColor = System.Drawing.Color.Transparent;
            this.gbyataklar.ForeColor = System.Drawing.Color.White;
            this.gbyataklar.Location = new System.Drawing.Point(12, 12);
            this.gbyataklar.Name = "gbyataklar";
            this.gbyataklar.Size = new System.Drawing.Size(466, 249);
            this.gbyataklar.TabIndex = 0;
            this.gbyataklar.TabStop = false;
            this.gbyataklar.Text = "Yataklar";
            // 
            // yataklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 269);
            this.Controls.Add(this.gbyataklar);
            this.Name = "yataklar";
            this.Text = "yataklar";
            this.Load += new System.EventHandler(this.yataklar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbyataklar;
    }
}