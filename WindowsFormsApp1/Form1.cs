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

       private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int birkenar, cevre, alan;

            birkenar = Convert.ToInt32(textBox1.Text);

            cevre = birkenar * 4;
            alan = birkenar * birkenar;

            label6.Text = alan.ToString();
            label7.Text = cevre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "KARE";
            label3.Visible = false;
            textBox2.Visible = false;
            button4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "DİKDÖRTGEN";
            label3.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            label2.Text = "Kısa Kenar";
            button3.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kısa, uzun, dikalan, dikcevre;

            kısa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            dikcevre = kısa * uzun;
            dikalan = (2 * kısa) + (2 * uzun);

            label6.Text = dikalan.ToString();
            label7.Text = dikcevre.ToString();
        }
    }
}
