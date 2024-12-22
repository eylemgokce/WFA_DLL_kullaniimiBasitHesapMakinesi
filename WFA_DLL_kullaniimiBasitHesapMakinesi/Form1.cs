using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matematik; //bizim yazdığımız kütüphane

namespace WFA_DLL_kullaniimiBasitHesapMakinesi
{
    public partial class Form1 : Form
    {
        MatematikIslemleri matematikIslemleri = new MatematikIslemleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_topla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1_sayi1.Text);
            int sayi2 = Convert.ToInt32(textBox2_sayi2.Text);
            int toplam = matematikIslemleri.topla(sayi1, sayi2);
            label4_sonuc.Text = toplam.ToString();
        }

        private void button2_cikar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1_sayi1.Text);
            int sayi2 = Convert.ToInt32(textBox2_sayi2.Text);
            int fark = matematikIslemleri.cikar(sayi1, sayi2);
            label4_sonuc.Text = fark.ToString();
        }

        private void button3_carpma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1_sayi1.Text);
            int sayi2 = Convert.ToInt32(textBox2_sayi2.Text);
            int carpim = matematikIslemleri.carp(sayi1, sayi2);
            label4_sonuc.Text= carpim.ToString();

        }

        private void button4_bolme_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1_sayi1.Text);
            int sayi2 = Convert.ToInt32(textBox2_sayi2.Text);
            double bolum = matematikIslemleri.bol(sayi1, sayi2);
            label4_sonuc.Text = bolum.ToString();
        }
    }
}
