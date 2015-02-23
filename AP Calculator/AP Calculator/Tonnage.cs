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
    public partial class Tonnage : Form
    {

        public double doMath(String a)
        {
          
            double num = 0;
            double den = 0;
            double extra = 0;
            double result = 0;
            
            if (a == "")
                return 0;

            if(a == "16ga")
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

        public Tonnage()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shapeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeBox.Text == "Round" | shapeBox.Text == "Square")
            {
                holeBox.Show();
                holeLab.Show();
                holeNumLab.Show();
                widLab.Hide();
                widBox.Hide();
                widNumLab.Hide();
                lenBox.Hide();
                lenLab.Hide();
                lenNumLab.Hide();
                thickBox.Show();
                thickLab.Show();
                thickNumLab.Show();

                
            }
            else
            {
                holeBox.Hide();
                holeLab.Hide();
                holeNumLab.Hide();
                widLab.Show();
                widBox.Show();
                widNumLab.Show();
                lenBox.Show();
                lenLab.Show();
                lenNumLab.Show();
                thickBox.Show();
                thickLab.Show();
                thickNumLab.Show();
            }

        }

        private void Tonnage_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p50 = 0;
            double p65 = 0;
            double p75 = 0;
            double p85 = 0;
            double g50 = 0;
            double stain = 0;
            double steel = 0;
            double alu = 0;
            double z =0;
            if (shapeBox.Text == "Round"  || shapeBox.Text == "Square")
            {
                p50 = Math.Ceiling(Double.Parse(holeNumLab.Text) * Double.Parse(thickNumLab.Text) * 80);
                p65 = Math.Ceiling(Double.Parse(holeNumLab.Text) * Double.Parse(thickNumLab.Text) * 102);
                p75 = Math.Ceiling(Double.Parse(holeNumLab.Text) * Double.Parse(thickNumLab.Text) * 118);
                p85 = Math.Ceiling(Double.Parse(holeNumLab.Text) * Double.Parse(thickNumLab.Text) * 134);
                g50 = Math.Ceiling(Double.Parse(holeNumLab.Text) * Double.Parse(thickNumLab.Text) * 128);
                stain = Math.Ceiling(Double.Parse(holeNumLab.Text) * Double.Parse(thickNumLab.Text) * 120);
                steel = Math.Ceiling(Double.Parse(holeNumLab.Text) * Double.Parse(thickNumLab.Text) * 99);
                alu = Math.Ceiling(Double.Parse(holeNumLab.Text) * Double.Parse(thickNumLab.Text) * 29);
            }
            else if (shapeBox.Text == "Rectangle")
            {
                double start = (((Double.Parse(lenNumLab.Text) + Double.Parse(widNumLab.Text))*0.63)*Double.Parse(thickNumLab.Text));
                p50 = Math.Ceiling(start*80);
                p65 = Math.Ceiling(start * 102);
                p75 = Math.Ceiling(start * 118);
                p85 = Math.Ceiling(start * 134);
                g50 = Math.Ceiling(start * 128);
                stain = Math.Ceiling(start * 120);
                steel = Math.Ceiling(start * 99);
                alu = Math.Ceiling(start * 29);
            }
            else if (shapeBox.Text == "Oblong")
            {
                z = Double.Parse(lenNumLab.Text) - Double.Parse(widNumLab.Text);
                double start = ((0.63 * z)+Double.Parse(widNumLab.Text))*Double.Parse(thickNumLab.Text);
                p50 = Math.Ceiling(start * 80);
                p65 = Math.Ceiling(start * 102);
                p75 = Math.Ceiling(start * 118);
                p85 = Math.Ceiling(start * 134);
                g50 = Math.Ceiling(start * 128);
                stain = Math.Ceiling(start * 120);
                steel = Math.Ceiling(start * 99);
                alu = Math.Ceiling(start * 29);
            }

            calc50.Text = p50.ToString();
            calc65.Text = p65.ToString();
            calc75.Text = p75.ToString();
            calc85.Text = p85.ToString();
            calcCarbon.Text = g50.ToString();
            calcStain.Text = stain.ToString();
            calcSteel.Text = steel.ToString();
            calcAlu.Text = alu.ToString();

        }

        private void holeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            holeNumLab.Text = doMath(holeBox.Text).ToString();
        }

        private void lenBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lenNumLab.Text = doMath(lenBox.Text).ToString();
        }

        private void widBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            widNumLab.Text = doMath(widBox.Text).ToString();
        }

        private void thickBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thickNumLab.Text = doMath(thickBox.Text).ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Tonnage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void steelLab_Click(object sender, EventArgs e)
        {

        }



    }
}
