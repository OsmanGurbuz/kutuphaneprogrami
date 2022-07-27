namespace WindowsFormsApp1
{
    partial class KitapEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.üyeKaydetButon = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.üyeSilButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(249, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kitap eklemek için kaydet butonuna basınız ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 22);
            this.textBox1.TabIndex = 13;
            // 
            // üyeKaydetButon
            // 
            this.üyeKaydetButon.Location = new System.Drawing.Point(135, 369);
            this.üyeKaydetButon.Name = "üyeKaydetButon";
            this.üyeKaydetButon.Size = new System.Drawing.Size(219, 46);
            this.üyeKaydetButon.TabIndex = 12;
            this.üyeKaydetButon.Text = "kaydet";
            this.üyeKaydetButon.UseVisualStyleBackColor = true;
            this.üyeKaydetButon.Click += new System.EventHandler(this.üyeKaydetButon_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "MUSTAFA KEMAL ATATÜRK - NUTUK",
            "A.M. CELAL ŞENGÖR - BİLGİYLE SOHBET ",
            "PLATON - SOKRATESİN SAVUNMASI",
            "F.M CONFORD - SOKRATES ÖNCESİ VE SONRASI",
            "A.M.CELAL ŞENGÖR -BİLİMİN BÜYÜSÜ",
            "JULES VERNE - DENİZLER ALTINDA YİRMİ BİN FELSAH ",
            "A.M. CELAL ŞENGÖR - HASAN ALİ YÜCEL VE TÜRK AYDINLANMASI",
            "VİCTOR HUGO - SEFİLLER ",
            "J.K.ROWLİNG - HARRY POTER - FELSEFE TAŞI",
            "JULES VERNE - DÜNYANIN MERKEZİNE YOLCULUK",
            "JULES VERNE - SEKSEN GÜNDE DÜNYA TURU",
            "SABAHATTİN ALİ - İÇİMİZDEKİ ŞEYTAN ",
            "T.A.BARON - MERLİN - KAYIP YILLAR",
            "ANDRE GİDE - PASTORAL SENFONİ",
            "STEFAN ZWEIG - SATRANÇ",
            "SİR ARTHUR CONAN DOYLE - SHERLOCK HOLMES - KUSURSUZ SUÇ YOKTUR"});
            this.listBox1.Location = new System.Drawing.Point(191, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 228);
            this.listBox1.TabIndex = 11;
            // 
            // üyeSilButton
            // 
            this.üyeSilButton.Location = new System.Drawing.Point(400, 369);
            this.üyeSilButton.Name = "üyeSilButton";
            this.üyeSilButton.Size = new System.Drawing.Size(219, 46);
            this.üyeSilButton.TabIndex = 15;
            this.üyeSilButton.Text = "sil";
            this.üyeSilButton.UseVisualStyleBackColor = true;
            this.üyeSilButton.Click += new System.EventHandler(this.üyeSilButton_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.üyeSilButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.üyeKaydetButon);
            this.Controls.Add(this.listBox1);
            this.Name = "KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapEklecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button üyeKaydetButon;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button üyeSilButton;
    }
}