namespace Hastane
{
    partial class frmHastaBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaBilgiDuzenle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.comboCins = new System.Windows.Forms.ComboBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textTelNo = new System.Windows.Forms.MaskedTextBox();
            this.textTc = new System.Windows.Forms.MaskedTextBox();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(99, 190);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 37);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // comboCins
            // 
            this.comboCins.FormattingEnabled = true;
            this.comboCins.Items.AddRange(new object[] {
            "Kadin",
            "Erkek"});
            this.comboCins.Location = new System.Drawing.Point(78, 161);
            this.comboCins.Name = "comboCins";
            this.comboCins.Size = new System.Drawing.Size(121, 23);
            this.comboCins.TabIndex = 20;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(78, 42);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(121, 23);
            this.textSoyad.TabIndex = 18;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(78, 13);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(121, 23);
            this.textAd.TabIndex = 19;
            // 
            // textTelNo
            // 
            this.textTelNo.Location = new System.Drawing.Point(78, 100);
            this.textTelNo.Mask = "(999) 000-0000";
            this.textTelNo.Name = "textTelNo";
            this.textTelNo.Size = new System.Drawing.Size(121, 23);
            this.textTelNo.TabIndex = 9;
            // 
            // textTc
            // 
            this.textTc.Enabled = false;
            this.textTc.Location = new System.Drawing.Point(78, 71);
            this.textTc.Mask = "00000000000";
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(121, 23);
            this.textTc.TabIndex = 10;
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(78, 129);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(121, 23);
            this.textSifre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefon No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "TC Kimlik No:";
            // 
            // frmHastaBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(225, 245);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.comboCins);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.textTelNo);
            this.Controls.Add(this.textTc);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHastaBilgiDuzenle";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.frmHastaBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuncelle;
        private ComboBox comboCins;
        private TextBox textSoyad;
        private TextBox textAd;
        private MaskedTextBox textTelNo;
        private MaskedTextBox textTc;
        private TextBox textSifre;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}