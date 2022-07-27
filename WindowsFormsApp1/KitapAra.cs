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
    public partial class KitapAra : Form
    {
        public KitapAra()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                // aranacakYer.Conteins(aranılacakYer)
                if (listBox1.Items[i].ToString().Contains(textBox1.Text))
                {
                    listBox1.SetSelected(i, true);
                    if (textBox1.Text=="")
                    {
                        listBox1.SetSelected(i, false);
                    }
                }
                else
                {
                    listBox1.SetSelected(i, false);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!= -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);    //seçili olanı aktar
                listBox1.Items.Remove(listBox1.SelectedItems);   // seçili olanı sil
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapın");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox1.SelectedItem);    //seçili olanı aktar
                listBox2.Items.Remove(listBox1.SelectedItems);   // seçili olanı sil
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapın");
            }
        }
    }
}
