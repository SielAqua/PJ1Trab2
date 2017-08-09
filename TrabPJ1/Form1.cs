using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabPJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Novinha, Sapeca";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\n");
            textBox1.AppendText("Se der bobeira o nosso bonde te pega"+ trackBar1.Value);

            if (checkBox1.Enabled == true)
            {
                checkBox1.Enabled = false;

            }

            else if(checkBox1.Enabled == false)
            {
                checkBox1.Enabled = true;
            }

            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
