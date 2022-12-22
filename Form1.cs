/*
Author: Ayman Mohammad
Date: June 3rd, 2021
Description: This program solves equations in quadratic form by calculating any real roots given an a, b, c value. It will also check if you can use factoring to solve the equation or use the quadratic formula.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_Solver
{
    public partial class FrmQuadraticSolver : Form
    {
        public FrmQuadraticSolver()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text), b = Convert.ToInt32(txtB.Text), c = Convert.ToInt32(txtC.Text); // converts the a, b, and c value from strings to integers.
            SetEquation(); // sets the equation based on what values are given.
            Solve(a, b, c); // functions to solve
        }

        // sets the equation to give a better idea to the user what they have entered and what their equation looks like.
        void SetEquation()
        {
            lblQuadratic.Text = String.Format("({0})x² + ({1})x + ({2}) = 0", txtA.Text, txtB.Text, txtC.Text);
        }

        // allows you to easily configure the other information in the GUI, if an empty string is used in one of the parameters it will be ignored.
        void SetInfo(string root1, string root2, string solutions, string factorable)
        {
            if(!String.IsNullOrEmpty(root1))
            {
                lblroot1.Text = "x₁ = " + root1;
            }
            if (!String.IsNullOrEmpty(root2))
            {
                lblroot2.Text = "x₂ = " + root2;
            }
            if (!String.IsNullOrEmpty(solutions))
            {
                lblSol.Text = "NUMBER OF SOLUTIONS: " + solutions;
            }
            if (!String.IsNullOrEmpty(factorable))
            {
                lblfactor.Text = "FACTORABLE: " + factorable;
            }
        }

        // calculates and returns the value of the discriminant.
        double GetDiscrim(int a, int b, int c)
        {
            return (Math.Pow(b, 2) - (4 * a * c));
        }

        // checks if the discriminant is a perfect square to check if the equation can be factored.
        bool PerfectSquare(double discrim)
        {
            if((Math.Pow(discrim, 0.5) % 1) == 0) // taking something to the exponent of one half is basically the same as square rooting the number
            {
                return true; // if the square root of the discriminant returns a whole number, then it is factorable.
            }
            else
            {
                return false;
            }
        }

        void Solve(int a, int b, int c)
        {
            double x1, x2;
            double d = GetDiscrim(a, b, c);

            // displays an error message if the a value is 0.
            if (a == 0)
            {
                SetInfo("N/A", "N/A", "cannot be solved", "False");
                MessageBox.Show("The a value cannot be 0.", "ERROR", MessageBoxButtons.OK);

            }
            // if the discriminant is less than 0, then it has no real solution but imaginary and complex ones.
            else if (d < 0)
            {
                SetInfo("N/A", "N/A", "no real solutions", "False");
            }
            else
            {
                // roots are both calculated.
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                // if the discriminant is 0 then there is only one solution (double root).
                if (d == 0)
                {
                    SetInfo(String.Format("{0}", x1), String.Format("{0}", x2), "one real solution", String.Format("{0}", PerfectSquare(d)));
                }
                // if it is a positive number then there are two real distinct roots.
                if (d > 0)
                {
                    SetInfo(String.Format("{0}", x1), String.Format("{0}", x2), "two real solutions", String.Format("{0}", PerfectSquare(d)));
                }
            }
        }


    }
}
