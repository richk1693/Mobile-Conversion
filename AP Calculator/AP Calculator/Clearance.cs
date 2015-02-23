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
    public partial class Clearance : Form
    {

        double num = .125;


        public Clearance()
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

        public static double gcd(double a, double b)
        {
            double n = Math.Min(a, b);
            double gcd = 1, i = 1;

            while (i <= n)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
                i++;
            }
            return gcd;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double add = 0;
            num = doMath(punBox.Text);
            if (doMath(thickBox.Text) < .25)
            {
                add = 0.015625;
            }
            else if (doMath(thickBox.Text) < .5)
            {
                add = 0.03125;
            }
            else if (doMath(thickBox.Text) < .75)
            {
                add = 0.0625;
            }
            else
            {
                add = 0.09375;
            }

            num += add;
            double den = 1000000;
            double res = 0;
            num = num * den;
            int front = 0;
            res = gcd(num, den);

            if (num < den)
                dieNumLab.Text = (num / res).ToString() + "/" + (den / res).ToString();
            else
            {
                num = num - den;
                front = 1;
                dieNumLab.Text = front + " " + (num / res).ToString() + "/" + (den / res).ToString();
            }


        }

        private void Clearance_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            
        }

        private void Clearance_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
        }

        private void dieLab_Click(object sender, EventArgs e)
        {

        }

        private void dieNumLab_Click(object sender, EventArgs e)
        {

        }

        private void thickLab_Click(object sender, EventArgs e)
        {

        }

        private void punLab_Click(object sender, EventArgs e)
        {

        }
    }
}
