using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_Heli
{
    public partial class Form1 : Form
    {
        private string expression = "";
        private string function = "";
        private ArrayList nums = new ArrayList();
        private string operation = "";
        private string ans = "";
        private double memory = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            expression = "";
            txtboxDisplay.Text = expression;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            expression = "";
            nums.Clear();
            operation = "";
            txtboxDisplay.Text = expression;
        }

        private void btnLesseqtp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(expression))
            {
                expression = expression.Substring(0, expression.Length - 1);
                txtboxDisplay.Text = expression;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";

        }
        

        private void cmsMC_Opening(object sender, CancelEventArgs e)
        {
            memory = 0;
        }

        private void cmsMR_Opening(object sender, CancelEventArgs e)
        {
            expression = memory.ToString();
            txtboxDisplay.Text = expression;
        }

        private void cmsMS_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                memory = Convert.ToDouble(expression);
            }
            catch
            {
                MessageBox.Show("Invalid input for memory storage", "Error");
            }
        }

       

        private void cmsMminus_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                memory -= Convert.ToDouble(expression);
            }
            catch
            {
                MessageBox.Show("Invalid input for memory subtraction", "Error");
            }
        }
        
        private void btnUndRoot_Click(object sender, EventArgs e)
        {
            try
            {
                expression = Math.Sqrt(double.Parse(expression)).ToString();
                txtboxDisplay.Text = expression;
            }
            catch
            {
                MessageBox.Show("Invalid input for square root", "Error");
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double localAns = 0;
            if (operation == "+")
                {
                    nums.Add(expression);
                    foreach (string item in nums)
                    {
                        localAns += Convert.ToDouble(item);
                    }
                }

            if(operation == "/")
            {
                nums.Add(expression);
                if(expression == "0") {
                    txtboxDisplay.Text = "invalid input";
                }
                else
                {
                    localAns= Convert.ToDouble(nums[0]) / Convert.ToDouble(nums[1]);
                }
            }

            if (operation == "-")
            {
                nums.Add(expression);
                localAns = Convert.ToDouble(nums[0]);
                for (int i = 1; i < nums.Count; i++)
                {
                    localAns -= Convert.ToDouble(nums[i]);
                }
            }

            if (operation == "*")
            {
                nums.Add(expression);
                localAns = Convert.ToDouble(nums[0]);
                for (int i = 1; i < nums.Count; i++)
                {
                    localAns *= Convert.ToDouble(nums[i]);
                }
            }
            txtboxDisplay.Text = localAns.ToString();
            nums.Clear();
            expression = localAns.ToString();
        }


        private void cmsMplus_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                memory += Convert.ToDouble(expression);
            }
            catch
            {
                MessageBox.Show("Invalid input for memory addition", "Error");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            expression += "1";
            txtboxDisplay.Text = expression;
        }


        private void btn2_Click_1(object sender, EventArgs e)
        {
            expression += "2";
            txtboxDisplay.Text = expression;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            expression += "3";
            txtboxDisplay.Text = expression;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            expression += "4";
            txtboxDisplay.Text = expression;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            expression += "5";
            txtboxDisplay.Text = expression;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            expression += "6";
            txtboxDisplay.Text = expression;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            expression += "7";
            txtboxDisplay.Text = expression;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            expression += "8";
            txtboxDisplay.Text = expression;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            expression += "9";
            txtboxDisplay.Text = expression;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            expression += "0";
            txtboxDisplay.Text = expression;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            if (expression.Contains(".") == false) {
                expression += ".";
            }
            txtboxDisplay.Text = expression;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            nums.Add(expression);
            expression = "";
            operation = "/";
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            nums.Add(expression);
            expression = "";
            operation = "*";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            nums.Add(expression);
            expression = "";
            operation = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            nums.Add(expression);
            expression = "";
            operation = "-";
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(expression))
            {
                double value = Convert.ToDouble(expression);
                value = -value;
                expression = value.ToString();
                txtboxDisplay.Text = expression;
            }
        }

        private void btnXintoX_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(expression);
                value = value * value;
                expression = value.ToString();
                txtboxDisplay.Text = expression;
            }
            catch
            {
                MessageBox.Show("Invalid input for square", "Error");
            }
        }

        private void btnOnebyX_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(expression);
                if (value == 0)
                {
                    txtboxDisplay.Text = "Invalid input";
                }
                else
                {
                    value = 1 / value;
                    expression = value.ToString();
                    txtboxDisplay.Text = expression;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input for reciprocal", "Error");
            }
        }
    }
}
