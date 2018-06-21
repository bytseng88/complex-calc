using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Final Exam
 * April 24, 2018
 * Author: Brian Tseng
 * Project Purpose: An app that does math with complex numbers
 * Input:  The user types in the values of the complex numbers
 * Desired Output:  When the 'Clear' button is pressed, all inputs and the result value is
 *                  reset to 0.
 *                  When the 'Mem A' or 'Mem B' button is pressed, the displayed result will
 *                  be saved to the corresponding input.
 *                  All other buttons when pressed display the result of the operation as
 *                  described in "Formulas".
 * Classes:  ComplexNumber
 * Formulas:  Addition: (a + bi) + (c + di) = (a + c) + (b + d)i
 *            Subtraction: (a + bi) - (c + di) = (a - c) + (b - d)i
 *            Multiplication: (a + bi) * (c + di) = (a * c - b * d) + (a * d + b * c)i
 *            Division: (a + bi) / (c + di) = ((a * c + b * d)/(c^2 + d^2)) + ((b * c - a * d)/(c^2 + d^2))i
 *            Negation: -(a + bi) = -a - bi
 *            Conjugate: Con(a + bi) = a - bi
 *            Absolute Value: |a + bi| = a^2 + b^2
 *            Inverse: (a + bi)^-1 = (a / (a^2 + b^2)) - (b / (a^2 + b^2))i
 * Testing:  Let A = 1 + 1i and B = 0 + 1i.
 *           -A = -1 - 1i
 *           Con(A) = 1 - 1i
 *           |A| = 1.414 (Square root of 2)
 *           A^-1 = 0.5 - 0.5i
 *           A + B = 1 + 2i
 *           A - B = 1
 *           A * B = -1 + 1i
 *           A / B = 1 - 1i
 */

namespace Complex_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalcForm());
        }
    }
}
