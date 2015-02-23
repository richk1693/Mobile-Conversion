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
    public partial class Diagonals : Form
    {

        public Diagonals()
        {
            InitializeComponent();
        }

        public double doMath(String a)
        {
           
            double num = 0;
            double den = 0;
            double extra = 0;
            double result = 0;

            if (a == "")
                return 0;
            if (a == "16ga")
                return 0.060;

            if (a == "12ga")
                return 0.105;

            switch (a.Length)
            {
                case 1:
                    {



                        result = Double.Parse(a);
                        break;
                    }

                case 3:
                    {

                        num = double.Parse(a.Substring(0, 1));
                        den = double.Parse(a.Substring(2, 1));
                        result = ((extra * den) + num) / den;
                        break;
                    }

                case 4:
                    {

                        num = double.Parse(a.Substring(0, 1));
                        den = double.Parse(a.Substring(2, 2));
                        result = ((extra * den) + num) / den;
                        break;
                    }

                case 5:
                    {
                        if (a.Contains("-"))
                        {
                            extra = double.Parse(a.Substring(0, 1));
                            num = double.Parse(a.Substring(2, 1));
                            den = double.Parse(a.Substring(4, 1));
                        }
                        else
                        {
                            num = double.Parse(a.Substring(0, 2));
                            den = double.Parse(a.Substring(3, 2));
                        }
                        result = ((extra * den) + num) / den;
                        break;
                    }

                case 6:
                    {
                        extra = double.Parse(a.Substring(0, 1));
                        num = double.Parse(a.Substring(2, 1));
                        den = double.Parse(a.Substring(4, 2));
                        result = ((extra * den) + num) / den;
                        break;
                    }

                case 7:
                    {
                        extra = double.Parse(a.Substring(0, 1));
                        num = double.Parse(a.Substring(2, 2));
                        den = double.Parse(a.Substring(5, 2));
                        result = ((extra * den) + num) / den;
                        break;
                    }
            }


            // holeNumLab.Text = extra.ToString();
            //lenNumLab.Text = num.ToString();
            //widNumLab.Text = den.ToString();
            //thickNumLab.Text = result.ToString();
            return result;
        }
        

        private void shapeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeBox.Text == "Square")
            {

                sizeLab.Text = "Size";
                sizeLab.Visible = true;
                sizeBox.Visible = true;
                lenBox.Visible = false;
                lenLab.Visible = false;
            }
            else if (shapeBox.Text == "Hexagon")
            {


                sizeLab.Text = "Size";
                sizeLab.Visible = true;
                sizeBox.Visible = true;
                lenBox.Visible = false;
                lenLab.Visible = false;
            }
            else if (shapeBox.Text == "Rectangle")
            {

                sizeLab.Text = "Width";
                sizeLab.Visible = true;
                sizeBox.Visible = true;
                lenBox.Visible = true;
                lenLab.Visible = true;
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (shapeBox.Text == "Square")
            {
                diagNumLab.Text = (doMath(sizeBox.Text) * 1.414).ToString();
            }
            else if (shapeBox.Text == "Hexagon")
            {
                diagNumLab.Text = (doMath(sizeBox.Text) * 1.1547).ToString();
            }
            else if (shapeBox.Text == "Rectangle")
            {
                double a = doMath(sizeBox.Text);
                double b = doMath(lenBox.Text);

                diagNumLab.Text = Math.Sqrt(((a * a) + (b * b))).ToString();
            }

            diagNumLab.Text = (Math.Round(double.Parse(diagNumLab.Text),5)).ToString();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Diagonals_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void diagNumLab_Click(object sender, EventArgs e)
        {

        }

        private void Diagonals_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
        }
    }
}
