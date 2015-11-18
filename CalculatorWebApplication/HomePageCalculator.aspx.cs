using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculatorUtilities;
using WcfServiceCalculator;

namespace CalculatorWebApplication
{
    public partial class HomePageCalculator : System.Web.UI.Page
    {
        private static double input1;
        private static double input2;
        private static string opr;
        double _result;
        Utility ut;
        static private bool equalpressed = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            ut = new Utility();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "1");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "2");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "3");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "4");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "5");

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "6");
        }

        protected void Button7_Click1(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "7");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "8");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "9");
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            ButtonEqualPressed();
            TextBox1.Text = ut.RemovePrecedingZero(TextBox1.Text, "0");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Format("{0}.", TextBox1.Text);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(TextBox1.Text);
            opr = "+";
            Label1.Text = TextBox1.Text + " " + opr;
            TextBox1.Text = " ";
            }

        protected void Button13_Click(object sender, EventArgs e)
        {
            CalculatorWcfService1 service1 = new CalculatorWcfService1();
            input2 = Convert.ToDouble(TextBox1.Text);
            switch (opr)
            {
                case  "+":
                    _result = service1.Addition(input1, input2);
                    TextBox1.Text = Convert.ToString(_result);
                    Label1.Text = " ";
                    break;
                case "-":
                    _result = service1.Substraction(input1, input2);
                    TextBox1.Text = Convert.ToString(_result);
                    Label1.Text = " ";
                    break;
                case "*":
                    _result = service1.Multiplication(input1, input2);
                    TextBox1.Text = Convert.ToString(_result);
                    Label1.Text = " ";
                    break;
                case "/":
                    _result = service1.Division(input1, input2);
                    TextBox1.Text = Convert.ToString(_result);
                    Label1.Text = " ";
                    break;
            }
            equalpressed = true;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(TextBox1.Text);
            opr = "-";
            Label1.Text = TextBox1.Text + " " + opr;
            TextBox1.Text = " ";
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(TextBox1.Text);
            opr = "*";
            Label1.Text = TextBox1.Text + " " + opr;
            TextBox1.Text = " ";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(TextBox1.Text);
            opr = "/";
            Label1.Text = TextBox1.Text + " " + opr;
            TextBox1.Text = " ";
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            Label1.Text = " ";
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1);
                if (TextBox1.Text.Length == 0)
                {
                    TextBox1.Text = "0";
                }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonEqualPressed()
        {
            if (equalpressed)
            {
                TextBox1.Text = "";
                equalpressed = false;
            }
        }
    }
}
