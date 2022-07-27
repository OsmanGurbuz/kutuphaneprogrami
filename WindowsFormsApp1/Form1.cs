using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            Kayıt kayit = new Kayıt();
            kayit.ShowDialog();
        }

        private void kitapEkleBtn_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();
        }

        private void cıkısbtn_Click(object sender, EventArgs e)
        {
            DialogResult secim = DialogResult.OK;
            secim = MessageBox.Show("Programdan ÇIkmak istiyormusunuz ?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            
            if (secim == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            KitapAra kitapAra = new KitapAra();
            kitapAra.ShowDialog();
        }

        
    }
}
