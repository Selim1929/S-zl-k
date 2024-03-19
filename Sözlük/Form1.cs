using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sözlük
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> kelimeler= new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            kelimeler.Add(textBoxCeviri1.Text,textBoxCeviri2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeler.Add("cat", "kedi");
            kelimeler.Add("dog", "köpek");
            kelimeler.Add("car", "araba");
        }

        private void textBoxCeviri1_TextChanged(object sender, EventArgs e)
        {
            foreach (var kelime in kelimeler)
            {
                if (kelime.Key == textBoxCeviri1.Text)
                {
                    textBoxCeviri2.Text = kelime.Value;
                    break;
                }
                else
                {
                    textBoxCeviri2.Text = "kelime bulunamadi";
                }

            }
        }
    }
}
