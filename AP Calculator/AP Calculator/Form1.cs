using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AP_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void tonnageButton_Click(object sender, EventArgs e)
        {
            Tonnage ton = new Tonnage();
            ton.Owner = this;
            this.Hide();
            ton.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Converter conv = new Converter();
            conv.Owner = this;
            this.Hide();
            conv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clearance clear = new Clearance();
            clear.Owner = this;
            this.Hide();
            clear.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Diagonals dia = new Diagonals();
            dia.Owner = this;
            this.Hide();
            dia.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
