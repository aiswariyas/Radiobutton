using System;
using System.Windows.Forms;

namespace Calculator
{




    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation;
        bool DotName;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "1";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "1";
            }
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "2";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "2";
            }
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "3";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "3";
            }
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "4";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "4";
            }
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "5";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "5";
            }
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "6";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "6";
            }
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "7";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "7";
            }
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "8";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "8";
            }
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (Displaybox.Text == "0" && Displaybox.Text != null)
            {
                Displaybox.Text = "9";
            }
            else
            {
                Displaybox.Text = Displaybox.Text + "9";
            }
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Displaybox.Text = Displaybox.Text + "0";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Displaybox.Text);
            Displaybox.Text = "0";
            Operation = "+";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Displaybox.Text);
            Displaybox.Text = "0";
            Operation = "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Displaybox.Text);
            Displaybox.Text = "0";
            Operation = "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Displaybox.Text);
            Displaybox.Text = "0";
            Operation = "/";

        }

        private void Points_Click(object sender, EventArgs e)
        {


            if (Displaybox.Text.Contains("."))
            {
                Displaybox.Text = Displaybox.Text;
            }

            else
            {
                Displaybox.Text = Displaybox.Text + ".";
            }

        }
    

        private void Equalto_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;


            SecondNumber = Convert.ToDouble(Displaybox.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Displaybox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Displaybox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Displaybox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    Displaybox.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    Displaybox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


