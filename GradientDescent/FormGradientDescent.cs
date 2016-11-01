using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathParserDLL;

namespace GradientDescent
{
    public partial class FormGradientDescent : Form
    {

        MathParser parser = new MathParser();
        Random rand = new Random();

        public FormGradientDescent()
        {
            InitializeComponent();
            labelResult.Text = "";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            method();
        }

        void method()
        {
            double x1j;
            double x2j;
            x1j = parser.Parse(textBoxX1.Text);
            if (Double.IsNaN(x1j))
            {
                x1j = rand.NextDouble() * 10;
            }
            x2j = parser.Parse(textBoxX2.Text);
            if (Double.IsNaN(x2j))
            {
                x2j = rand.NextDouble() * 10;
            }
            double eps = 0.01;
            double delta = 0.01;
            double x1jj, x2jj;
            double flk, lk;
            double gradx1, gradx2;
            double dx1, dx2;
            int n = 1000, j = 0, err=0;
            string func, f, fx1, fx2, flam, flami;

            func = textBoxFunction.Text;

            do
            {
                List<double> fli = new List<double>();
                List<double> li = new List<double>();

                //--------------------------------------------------------
                f = func;
                fx1 = func;
                fx2 = func;
                flam = func;
                f = f.Replace("x1", "(" + x1j.ToString() + ")");
                f = f.Replace("x2", "(" + x2j.ToString() + ")");
                fx1 = fx1.Replace("x1", "(" + (x1j + delta).ToString() + ")");
                fx1 = fx1.Replace("x2", "(" + x2j.ToString() + ")");
                fx2 = fx2.Replace("x1", "(" + x1j.ToString() + ")");
                fx2 = fx2.Replace("x2", "(" + (x2j + delta).ToString() + ")");

                double Fx1 = parser.Parse(fx1);
                if (Double.IsNaN(Fx1))
                {
                    err = -1;
                    /*MessageBox.Show("Check expression, or enter a valid initial approximation");
                    x1j = Double.NaN;
                    x2j = Double.NaN;*/
                    break;
                }
                double Fx2 = parser.Parse(fx2);
                if (Double.IsNaN(Fx2))
                {
                    err = -1;
                    /*MessageBox.Show("Check expression, or enter a valid initial approximation");
                    x1j = Double.NaN;
                    x2j = Double.NaN;*/
                    break;
                }
                double F = parser.Parse(f);
                if (Double.IsNaN(F))
                {
                    err = -1;
                    /*MessageBox.Show("Check expression, or enter a valid initial approximation");
                    x1j = Double.NaN;
                    x2j = Double.NaN;*/
                    break;
                }
                gradx1 = (Fx1 - F) / delta;
                gradx2 = (Fx2 - F) / delta;

                double norm = Math.Sqrt(Math.Pow(gradx1, 2) + Math.Pow(gradx2, 2));
                gradx1 = gradx1 / norm;
                gradx2 = gradx2 / norm;

                /*MessageBox.Show(x1j.ToString());
                MessageBox.Show(x2j.ToString());
                MessageBox.Show(gradx1.ToString());
                MessageBox.Show(gradx2.ToString());*/
                //--------------------------------------------------------

                //--------------------------------------------------------
                flam = flam.Replace("x1", "(" + "(" + x1j.ToString() + ")" + "-(lam*" + "(" + gradx1.ToString() + "))" + ")");
                flam = flam.Replace("x2", "(" + "(" + x2j.ToString() + ")" + "-(lam*" + "(" + gradx2.ToString() + "))" + ")");
                for (int i = 1; i < n + 1; i++)
                {
                    li.Add(i * 1.0 / (n + 1.0));
                    flami = flam.Replace("lam", "(" + li[(i - 1)].ToString() + ")");
                    double Flami = parser.Parse(flami);
                    if (Double.IsNaN(Flami))
                    {
                        err = -1;
                        /*MessageBox.Show("Check expression, or enter a valid initial approximation");
                        x1j = Double.NaN;
                        x2j = Double.NaN;*/
                        break;
                    }
                    fli.Add(Flami);
                }
                fli.RemoveAll(
                    delegate(double d)
                    {
                        return Double.IsNaN(d);
                    }
                    );
                if (fli.Count == 0) { break; }
                flk = fli.Min();
                int k = fli.FindIndex(
                    delegate(double d)
                    {
                        return d == flk;
                    }
                    );
                lk = li[k];
                //MessageBox.Show(lk.ToString());
                //--------------------------------------------------------

                //--------------------------------------------------------
                x1jj = x1j - lk * gradx1;
                x2jj = x2j - lk * gradx2;
                dx1 = x1jj - x1j;
                dx2 = x2jj - x2j;
                x1j = x1jj;
                x2j = x2jj;
                j++;
                //--------------------------------------------------------

                if (j == 1000) { break; }
            }
            while ((Math.Abs(dx1) > eps) || (Math.Abs(dx2) > eps));

            if (err == -1)
            {
                labelResult.Text = "Check expression,\nand/or enter the initial approximation";
            }
            else
            {
                labelResult.Text = "x1 = " + x1j.ToString() + "\n";
                labelResult.Text += "x2 = " + x2j.ToString() + "\n";
            }
            /*MessageBox.Show(x1j.ToString());
            MessageBox.Show(x2j.ToString());*/
        }
    }
}
