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
    public partial class Converter : Form
    {
        public Boolean isReal (String s){

            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    if (s[i] != '.')
                        return false;
                }
            }

            return true;
        }

        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isReal(numBox.Text) && isReal(denBox.Text))
                decNumLab.Text = (double.Parse(numBox.Text) / double.Parse(denBox.Text)).ToString() + " Inches";
            else
                decNumLab.Text = "Invalid.";
        }

        private void mmButton_Click(object sender, EventArgs e)
        {
            if (isReal(mmBox.Text))
                mmNumLab.Text = Math.Round((double.Parse(mmBox.Text) * 0.0393701), 4).ToString() + " Inches";
            else
                mmNumLab.Text = "Invalid.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isReal(inBox.Text))
                inNumLab.Text = (double.Parse(inBox.Text) * 25.4).ToString() + " mm";
            else
                inNumLab.Text = "Invalid.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.Close();
            //this.Visible = false;

        }

        
        private void Divider1_Click(object sender, EventArgs e)
        {

        }

        private void numBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Converter_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        
    }
}
