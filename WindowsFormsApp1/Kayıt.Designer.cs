namespace WindowsFormsApp1
{
    partial class Kayıt
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.üyeKaydetButon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.üyeSilButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(234, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 228);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.üyeKaydetButon_Click);
            // 
            // üyeKaydetButon
            // 
            this.üyeKaydetButon.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyeKaydetButon.Location = new System.Drawing.Point(201, 370);
            this.üyeKaydetButon.Name = "üyeKaydetButon";
            this.üyeKaydetButon.Size = new System.Drawing.Size(219, 46);
            this.üyeKaydetButon.TabIndex = 1;
            this.üyeKaydetButon.Text = "kaydet";
            this.üyeKaydetButon.UseVisualStyleBackColor = true;
            this.üyeKaydetButon.Click += new System.EventHandler(this.üyeKaydetButon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kütüphaneye yeni üye kaydı için aşşağıdaki kutucuğa isminizi giriniz ve kaydet bu" +
    "tonuna basınız";
            // 
            // üyeSilButton
            // 
            this.üyeSilButton.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyeSilButton.Location = new System.Drawing.Point(486, 370);
            this.üyeSilButton.Name = "üyeSilButton";
            this.üyeSilButton.Size = new System.Drawing.Size(219, 46);
            this.üyeSilButton.TabIndex = 11;
            this.üyeSilButton.Text = "sil";
            this.üyeSilButton.UseVisualStyleBackColor = true;
            this.üyeSilButton.Click += new System.EventHandler(this.üyeSilButton_Click);
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.üyeSilButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.üyeKaydetButon);
            this.Controls.Add(this.listBox1);
            this.Name = "Kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.Kayıt_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button üyeKaydetButon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button üyeSilButton;
    }
}