using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double NUMMER = 0;
        double NUMMMER = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            NUMMMER++;
            for (int i = 0; i < 30; i++)
            {
                NUMMMER = NUMMER + NUMMMER;
                textBox1.Text = textBox1.Text + " " + NUMMMER.ToString();
                NUMMER = NUMMER + NUMMMER;
                textBox1.Text = textBox1.Text + " " + NUMMER.ToString();
            }
        }
    }
}
