using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;//10 hanelı yazı yazabılırız sadece
            textBox1.HideSelection = false;
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.SelectionStart.ToString() + ".karakterden sonra"+" "+  textBox1.SelectionLength.ToString()+" "+ "karakter seçtin";
            //textbox1.selectionstart.tostring = yazının arkasında kaç sayı yada harf varsa o sayıyı yazar start yanı baslama noktasından gerısını yazar.
            //textbox1.selectionlengt.tostring = kaç tane harf veya sayı secıldıyse onu yazdırır.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();//textboxun içinde ne yazıyorsa hepsini seçer.
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Copy();//textbox1 içindekı secılı alanı kopyalar.     
            textBox2.Copy();//textbox2 içindekı secılı alanı kopyalar.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Paste();//textbox1 içine kopyalanmıs yazıyı yapıştırır.
            textBox2.Paste();//textbox2 içindekı kopyalanmıs yazıyı yapıstırır.
        }

       
    }
}
