namespace Sinema_Büfe_Satis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBilet = new System.Windows.Forms.TextBox();
            this.TxtCay = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.LblBilet = new System.Windows.Forms.Label();
            this.LblCay = new System.Windows.Forms.Label();
            this.LblSu = new System.Windows.Forms.Label();
            this.TxtMisir = new System.Windows.Forms.TextBox();
            this.LblMisir = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.LblKasa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblToplam = new System.Windows.Forms.Label();
            this.Toplam = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.TxtBilet);
            this.groupBox1.Controls.Add(this.TxtCay);
            this.groupBox1.Controls.Add(this.TxtSu);
            this.groupBox1.Controls.Add(this.LblBilet);
            this.groupBox1.Controls.Add(this.LblCay);
            this.groupBox1.Controls.Add(this.LblSu);
            this.groupBox1.Controls.Add(this.TxtMisir);
            this.groupBox1.Controls.Add(this.LblMisir);
            this.groupBox1.Location = new System.Drawing.Point(78, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Miktar";
            // 
            // TxtBilet
            // 
            this.TxtBilet.Location = new System.Drawing.Point(75, 161);
            this.TxtBilet.Name = "TxtBilet";
            this.TxtBilet.Size = new System.Drawing.Size(100, 26);
            this.TxtBilet.TabIndex = 7;
            this.TxtBilet.Text = "0";
            // 
            // TxtCay
            // 
            this.TxtCay.Location = new System.Drawing.Point(75, 119);
            this.TxtCay.Name = "TxtCay";
            this.TxtCay.Size = new System.Drawing.Size(100, 26);
            this.TxtCay.TabIndex = 6;
            this.TxtCay.Text = "0";
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(77, 80);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(100, 26);
            this.TxtSu.TabIndex = 5;
            this.TxtSu.Text = "0";
            // 
            // LblBilet
            // 
            this.LblBilet.AutoSize = true;
            this.LblBilet.Location = new System.Drawing.Point(20, 164);
            this.LblBilet.Name = "LblBilet";
            this.LblBilet.Size = new System.Drawing.Size(46, 19);
            this.LblBilet.TabIndex = 4;
            this.LblBilet.Text = "Bilet:";
            // 
            // LblCay
            // 
            this.LblCay.AutoSize = true;
            this.LblCay.Location = new System.Drawing.Point(20, 119);
            this.LblCay.Name = "LblCay";
            this.LblCay.Size = new System.Drawing.Size(41, 19);
            this.LblCay.TabIndex = 3;
            this.LblCay.Text = "Çay:";
            this.LblCay.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblSu
            // 
            this.LblSu.AutoSize = true;
            this.LblSu.Location = new System.Drawing.Point(20, 83);
            this.LblSu.Name = "LblSu";
            this.LblSu.Size = new System.Drawing.Size(31, 19);
            this.LblSu.TabIndex = 2;
            this.LblSu.Text = "Su:";
            this.LblSu.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtMisir
            // 
            this.TxtMisir.Location = new System.Drawing.Point(75, 34);
            this.TxtMisir.Name = "TxtMisir";
            this.TxtMisir.Size = new System.Drawing.Size(100, 26);
            this.TxtMisir.TabIndex = 1;
            this.TxtMisir.Text = "0";
            // 
            // LblMisir
            // 
            this.LblMisir.AutoSize = true;
            this.LblMisir.Location = new System.Drawing.Point(20, 41);
            this.LblMisir.Name = "LblMisir";
            this.LblMisir.Size = new System.Drawing.Size(51, 19);
            this.LblMisir.TabIndex = 0;
            this.LblMisir.Text = "Mısır:";
            this.LblMisir.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(314, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Tablosu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bilet: 65 TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Çay: 15 TL";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Su: 7 TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mısır: 35 TL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Orange;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.LblKasa);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.LblToplam);
            this.groupBox3.Controls.Add(this.Toplam);
            this.groupBox3.Location = new System.Drawing.Point(482, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 254);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "00 TL";
            // 
            // LblKasa
            // 
            this.LblKasa.AutoSize = true;
            this.LblKasa.Location = new System.Drawing.Point(44, 192);
            this.LblKasa.Name = "LblKasa";
            this.LblKasa.Size = new System.Drawing.Size(57, 19);
            this.LblKasa.TabIndex = 8;
            this.LblKasa.Text = "Kasa : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblToplam
            // 
            this.LblToplam.AutoSize = true;
            this.LblToplam.Location = new System.Drawing.Point(95, 57);
            this.LblToplam.Name = "LblToplam";
            this.LblToplam.Size = new System.Drawing.Size(49, 19);
            this.LblToplam.TabIndex = 6;
            this.LblToplam.Text = "00 TL";
            this.LblToplam.Click += new System.EventHandler(this.label10_Click);
            // 
            // Toplam
            // 
            this.Toplam.AutoSize = true;
            this.Toplam.Location = new System.Drawing.Point(38, 57);
            this.Toplam.Name = "Toplam";
            this.Toplam.Size = new System.Drawing.Size(63, 19);
            this.Toplam.TabIndex = 5;
            this.Toplam.Text = "Toplam:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(111, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(403, 47);
            this.label11.TabIndex = 3;
            this.label11.Text = "Sinema Büfe Satış Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(801, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Büfe Sinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMisir;
        private System.Windows.Forms.Label LblMisir;
        private System.Windows.Forms.Label LblCay;
        private System.Windows.Forms.Label LblSu;
        private System.Windows.Forms.TextBox TxtBilet;
        private System.Windows.Forms.TextBox TxtCay;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.Label LblBilet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblToplam;
        private System.Windows.Forms.Label Toplam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblKasa;
        private System.Windows.Forms.Button button2;
    }
}
