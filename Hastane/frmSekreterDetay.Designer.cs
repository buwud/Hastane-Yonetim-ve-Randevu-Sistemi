﻿namespace Hastane
{
    partial class frmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rchDuyuru = new System.Windows.Forms.RichTextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.checkbxRandevu = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataBranslar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataDoktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDoktorPanel = new System.Windows.Forms.Button();
            this.btnBransPanel = new System.Windows.Forms.Button();
            this.btnRandevuList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBranslar)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(97, 51);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(54, 15);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adı - Soyadı:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(97, 19);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(73, 15);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // rchDuyuru
            // 
            this.rchDuyuru.Location = new System.Drawing.Point(6, 22);
            this.rchDuyuru.Name = "rchDuyuru";
            this.rchDuyuru.Size = new System.Drawing.Size(195, 127);
            this.rchDuyuru.TabIndex = 2;
            this.rchDuyuru.Text = "";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(6, 155);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(195, 33);
            this.btnOlustur.TabIndex = 3;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Controls.Add(this.rchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.checkbxRandevu);
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.mskTc);
            this.groupBox3.Controls.Add(this.mskSaat);
            this.groupBox3.Controls.Add(this.mskTarih);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(225, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 285);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "TC:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 1;
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(81, 54);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(100, 23);
            this.mskTarih.TabIndex = 2;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(81, 85);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(100, 23);
            this.mskSaat.TabIndex = 2;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(81, 115);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 23);
            this.cmbBrans.TabIndex = 3;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(81, 144);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(121, 23);
            this.cmbDoktor.TabIndex = 3;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(81, 173);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(100, 23);
            this.mskTc.TabIndex = 2;
            this.mskTc.ValidatingType = typeof(System.DateTime);
            // 
            // checkbxRandevu
            // 
            this.checkbxRandevu.AutoSize = true;
            this.checkbxRandevu.Location = new System.Drawing.Point(81, 205);
            this.checkbxRandevu.Name = "checkbxRandevu";
            this.checkbxRandevu.Size = new System.Drawing.Size(102, 19);
            this.checkbxRandevu.TabIndex = 4;
            this.checkbxRandevu.Text = "Randevu dolu.";
            this.checkbxRandevu.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(29, 230);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(169, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(29, 255);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(169, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataBranslar);
            this.groupBox4.Location = new System.Drawing.Point(460, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 224);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataBranslar
            // 
            this.dataBranslar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBranslar.Location = new System.Drawing.Point(3, 19);
            this.dataBranslar.Name = "dataBranslar";
            this.dataBranslar.RowTemplate.Height = 25;
            this.dataBranslar.Size = new System.Drawing.Size(283, 202);
            this.dataBranslar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataDoktorlar);
            this.groupBox5.Location = new System.Drawing.Point(460, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 216);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataDoktorlar
            // 
            this.dataDoktorlar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoktorlar.Location = new System.Drawing.Point(3, 19);
            this.dataDoktorlar.Name = "dataDoktorlar";
            this.dataDoktorlar.RowTemplate.Height = 25;
            this.dataDoktorlar.Size = new System.Drawing.Size(283, 194);
            this.dataDoktorlar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.btnRandevuList);
            this.groupBox6.Controls.Add(this.btnBransPanel);
            this.groupBox6.Controls.Add(this.btnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(13, 303);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(441, 155);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnDoktorPanel
            // 
            this.btnDoktorPanel.Location = new System.Drawing.Point(11, 22);
            this.btnDoktorPanel.Name = "btnDoktorPanel";
            this.btnDoktorPanel.Size = new System.Drawing.Size(139, 33);
            this.btnDoktorPanel.TabIndex = 3;
            this.btnDoktorPanel.Text = "Doktor Paneli";
            this.btnDoktorPanel.UseVisualStyleBackColor = true;
            // 
            // btnBransPanel
            // 
            this.btnBransPanel.Location = new System.Drawing.Point(156, 22);
            this.btnBransPanel.Name = "btnBransPanel";
            this.btnBransPanel.Size = new System.Drawing.Size(139, 33);
            this.btnBransPanel.TabIndex = 3;
            this.btnBransPanel.Text = "Branş Paneli";
            this.btnBransPanel.UseVisualStyleBackColor = true;
            // 
            // btnRandevuList
            // 
            this.btnRandevuList.Location = new System.Drawing.Point(11, 61);
            this.btnRandevuList.Name = "btnRandevuList";
            this.btnRandevuList.Size = new System.Drawing.Size(139, 33);
            this.btnRandevuList.TabIndex = 3;
            this.btnRandevuList.Text = "Randevu Liste";
            this.btnRandevuList.UseVisualStyleBackColor = true;
            // 
            // frmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 470);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSekreterDetay";
            this.Text = "frmSekreterDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBranslar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAdSoyad;
        private Label label3;
        private Label lblTc;
        private Label label1;
        private RichTextBox rchDuyuru;
        private Button btnOlustur;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnGuncelle;
        private Button btnKaydet;
        private CheckBox checkbxRandevu;
        private ComboBox cmbDoktor;
        private ComboBox cmbBrans;
        private MaskedTextBox mskTc;
        private MaskedTextBox mskSaat;
        private MaskedTextBox mskTarih;
        private TextBox txtId;
        private Label label8;
        private Label label7;
        private GroupBox groupBox4;
        private DataGridView dataBranslar;
        private GroupBox groupBox5;
        private DataGridView dataDoktorlar;
        private GroupBox groupBox6;
        private Button btnRandevuList;
        private Button btnBransPanel;
        private Button btnDoktorPanel;
    }
}