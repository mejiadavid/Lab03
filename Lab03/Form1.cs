using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        bool x = true;
        int i = 28;
        int[] my = { 5, 10, 15 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hola Mundo!";
            button1.Text = "Check";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "David Mejia";
            textBox2.Text = x.ToString();
            textBox3.Text = "" + i;
            for (int z = 0; z < 3; z++)
            {
                textBox3.Text += "," + my[z];
            }
        }
    }
}
