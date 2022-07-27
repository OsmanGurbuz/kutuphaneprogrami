namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kitapAraBtn = new System.Windows.Forms.Button();
            this.kitapEkleBtn = new System.Windows.Forms.Button();
            this.cıkısbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.kayitBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üey Kaydı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Üye Kaydı İçin tıklayınız";
            // 
            // kayitBtn
            // 
            this.kayitBtn.Location = new System.Drawing.Point(39, 69);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(185, 43);
            this.kayitBtn.TabIndex = 1;
            this.kayitBtn.Text = "Kayıt";
            this.kayitBtn.UseVisualStyleBackColor = true;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.kitapAraBtn);
            this.groupBox2.Controls.Add(this.kitapEkleBtn);
            this.groupBox2.Location = new System.Drawing.Point(437, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 306);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemkeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "\"Kitap Ara\" butonuna basınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Aramak ve Almak için";
            // 
            // kitapAraBtn
            // 
            this.kitapAraBtn.Location = new System.Drawing.Point(37, 212);
            this.kitapAraBtn.Name = "kitapAraBtn";
            this.kitapAraBtn.Size = new System.Drawing.Size(185, 45);
            this.kitapAraBtn.TabIndex = 2;
            this.kitapAraBtn.Text = "Kitap Ara";
            this.kitapAraBtn.UseVisualStyleBackColor = true;
            this.kitapAraBtn.Click += new System.EventHandler(this.kitapAraBtn_Click);
            // 
            // kitapEkleBtn
            // 
            this.kitapEkleBtn.Location = new System.Drawing.Point(37, 41);
            this.kitapEkleBtn.Name = "kitapEkleBtn";
            this.kitapEkleBtn.Size = new System.Drawing.Size(185, 41);
            this.kitapEkleBtn.TabIndex = 0;
            this.kitapEkleBtn.Text = "Kitap ekle";
            this.kitapEkleBtn.UseVisualStyleBackColor = true;
            this.kitapEkleBtn.Click += new System.EventHandler(this.kitapEkleBtn_Click);
            // 
            // cıkısbtn
            // 
            this.cıkısbtn.Location = new System.Drawing.Point(278, 386);
            this.cıkısbtn.Name = "cıkısbtn";
            this.cıkısbtn.Size = new System.Drawing.Size(175, 41);
            this.cıkısbtn.TabIndex = 3;
            this.cıkısbtn.Text = "Çıkış";
            this.cıkısbtn.UseVisualStyleBackColor = true;
            this.cıkısbtn.Click += new System.EventHandler(this.cıkısbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(824, 490);
            this.Controls.Add(this.cıkısbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kayitBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kitapAraBtn;
        private System.Windows.Forms.Button kitapEkleBtn;
        private System.Windows.Forms.Button cıkısbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

