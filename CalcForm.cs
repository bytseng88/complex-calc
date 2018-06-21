using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complex_Calculator
{
    public partial class CalcForm : Form
    {
        ComplexNumber cNumA, cNumB, cResult;
        public CalcForm()
        {
            InitializeComponent();
            cNumA = new ComplexNumber();
            cNumB = new ComplexNumber();
            cResult = new ComplexNumber();
            numARealTBox.Text = cNumA.Real.ToString();
            numAImgTBox.Text = cNumA.Imaginary.ToString();
            numBRealTBox.Text = cNumB.Real.ToString();
            numBImgTBox.Text = cNumB.Imaginary.ToString();
            resultLabel.Text = cResult.ToString();
        }

        private bool isFraction(string testFrac, out double val)
        {
            val = 0;
            double numerator, denominator;
            char[] divider = { '/' };
            string[] numTokens = testFrac.Split(divider);
            if (double.TryParse(numTokens[0], out numerator) && double.TryParse(numTokens[1], out denominator))
            {
                val = numerator / denominator;
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool isComplex(string realStr, string imgStr, out ComplexNumber cNum)
        {
            cNum = new ComplexNumber();
            double numReal, numImg;
            if ((double.TryParse(realStr, out numReal) || isFraction(realStr, out numReal)) &&
                (double.TryParse(imgStr, out numImg) || isFraction(imgStr, out numImg)))
            {
                cNum = new ComplexNumber(numReal, numImg);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void readInput(bool readB) // reads only A if false, reads both if true
        {
            // verifying input A is a number
            if (!isComplex(numARealTBox.Text, numAImgTBox.Text, out cNumA))
            {
                MessageBox.Show("Input for A is not in numeric form.");
            }
            // verifying input B is a number
            if (readB)
            {
                if (!isComplex(numBRealTBox.Text, numBImgTBox.Text, out cNumB))
                {
                    MessageBox.Show("Input for B is not in numeric form.");
                }
            }
        }
        private void dispResult()
        {
            resultLabel.Text = cResult.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            numARealTBox.Text = "0";
            numAImgTBox.Text = "0";
            numBRealTBox.Text = "0";
            numBImgTBox.Text = "0";
            resultLabel.Text = "0";
        }
        private void memABtn_Click(object sender, EventArgs e)
        {
            numARealTBox.Text = cResult.Real.ToString();
            numAImgTBox.Text = cResult.Imaginary.ToString();
        }
        private void memBBtn_Click(object sender, EventArgs e)
        {
            numBRealTBox.Text = cResult.Real.ToString();
            numBImgTBox.Text = cResult.Imaginary.ToString();
        }

        private void negBtn_Click(object sender, EventArgs e)
        {
            readInput(false);
            cResult = -cNumA;
            dispResult();
        }
        private void invBtn_Click(object sender, EventArgs e)
        {
            readInput(false);
            try
            {
                cResult = cNumA.Inverse(); // throws DivideByZero
                dispResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void conjBtn_Click(object sender, EventArgs e)
        {
            readInput(false);
            cResult = cNumA.Conjugate();
            dispResult();
        }
        private void absBtn_Click(object sender, EventArgs e)
        {
            readInput(false);
            cResult = cNumA.AbsoluteValue(); // implicit conversion from Double to ComplexNumber
            dispResult();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            readInput(true);
            cResult = cNumA + cNumB;
            dispResult();
        }
        private void subBtn_Click(object sender, EventArgs e)
        {
            readInput(true);
            cResult = cNumA - cNumB;
            dispResult();
        }
        private void multBtn_Click(object sender, EventArgs e)
        {
            readInput(true);
            cResult = cNumA * cNumB;
            dispResult();
        }
        private void divBtn_Click(object sender, EventArgs e)
        {
            readInput(true);
            try
            {
                cResult = cNumA / cNumB; // throws DivideByZero
                dispResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
