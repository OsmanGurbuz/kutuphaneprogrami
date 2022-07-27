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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        

        private void üyeKaydetButon_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.ToString());
            textBox1.Text = "";

        }

        private void üyeSilButton_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                listBox1.Items.RemoveAt(secim);
            }       
            else
            {
                MessageBox.Show("Seçim yapın");
            }
            textBox1.Text = "";
        }
    }
}
