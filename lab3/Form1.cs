using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbHrn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void tbHrn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void tbCop1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void tbCop2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }
 private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            Money Sum = new Money();
            float X = (float)Convert.ToDouble(tbHrn1.Text);
            float Y = (float)Convert.ToDouble(tbHrn2.Text);
            Sum.SumHrns1(X, Y);
            float I = (float)Convert.ToDouble(tbCop1.Text);
            float O = (float)Convert.ToDouble(tbCop2.Text);
            Sum.SumHrns2(I, O);   
            this.resHrn.Text = Convert.ToString(Sum.Sum(Sum.HrnsFirst,Sum.HrnsSecond));
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            Money Sub = new Money();
            float X = (float)Convert.ToDouble(tbHrn1.Text);
            float Y = (float)Convert.ToDouble(tbHrn2.Text);
            Sub.SumHrns1(X, Y);
            X = (float)Convert.ToDouble(tbCop1.Text);
            Y = (float)Convert.ToDouble(tbCop2.Text);
            Sub.SumHrns2(X, Y);
            this.resHrn.Text = Convert.ToString(Sub.Sub(Sub.HrnsFirst, Sub.HrnsSecond));
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Money Mul = new Money();
            float X = (float)Convert.ToDouble(tbHrn1.Text);
            float Y = (float)Convert.ToDouble(tbHrn2.Text);
            Mul.SumHrns1(X, Y);
            X = (float)Convert.ToDouble(tbCop1.Text);
            Y = (float)Convert.ToDouble(tbCop2.Text);
            Mul.SumHrns2(X, Y);
            this.resHrn.Text = Convert.ToString(Mul.Mul(Mul.HrnsFirst, Mul.HrnsSecond));
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Money Div = new Money();
            float X = (float)Convert.ToDouble(tbHrn1.Text);
            float Y = (float)Convert.ToDouble(tbHrn2.Text);
            Div.SumHrns1(X, Y);
            X = (float)Convert.ToDouble(tbCop1.Text);
            Y = (float)Convert.ToDouble(tbCop2.Text);
            Div.SumHrns2(X, Y);
            this.resHrn.Text = Convert.ToString(Div.Div(Div.HrnsFirst, Div.HrnsSecond));
        }

        private void btnSum2_Click(object sender, EventArgs e)
        {
             Fraction Sum = new Fraction();
             float X = (float)Convert.ToDouble(tbFull1.Text);
             float Y = (float)Convert.ToDouble(tbFull2.Text);
             string I = tbFrac1.Text;
             string O = tbFrac2.Text;
             Sum.SumFirst(X, I);
             Sum.SumSecond(Y, O);
             this.lblRes.Text = Convert.ToString(Sum.Sum(Sum.FirstNum, Sum.SecondNum));
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            Fraction Sub = new Fraction();
            float X = (float)Convert.ToDouble(tbFull1.Text);
            float Y = (float)Convert.ToDouble(tbFull2.Text);
            string I = tbFrac1.Text;
            string O = tbFrac2.Text;
            Sub.SumFirst(X, I);
            Sub.SumSecond(Y, O);
            this.lblRes.Text = Convert.ToString(Sub.Sub(Sub.FirstNum, Sub.SecondNum));
        }

        private void btnMul2_Click(object sender, EventArgs e)
        {
            Fraction Mul = new Fraction();
            float X = (float)Convert.ToDouble(tbFull1.Text);
            float Y = (float)Convert.ToDouble(tbFull2.Text);
            string I = tbFrac1.Text;
            string O = tbFrac2.Text;
            Mul.SumFirst(X, I);
            Mul.SumSecond(Y, O);
            this.lblRes.Text = Convert.ToString(Mul.Mul(Mul.FirstNum, Mul.SecondNum));
        }

        private void btnDiv2_Click(object sender, EventArgs e)
        {
            Fraction Div = new Fraction();
            float X = (float)Convert.ToDouble(tbFull1.Text);
            float Y = (float)Convert.ToDouble(tbFull2.Text);
            string I = tbFrac1.Text;
            string O = tbFrac2.Text;
            Div.SumFirst(X, I);
            Div.SumSecond(Y, O);
            this.lblRes.Text = Convert.ToString(Div.Div(Div.FirstNum, Div.SecondNum));
        }

        private void tbFull1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void tbFull2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void tbFrac1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void tbFrac2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }
    }
}
