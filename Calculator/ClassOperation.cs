using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class ClassOperation
    {
        string num1 = "";
        string num2 = "";
        string num3 = "";

        int NextNum = 0;
        int opt = -1;

        bool minus = false;
        bool minus2 = false;


        public void Solution(TextBox textBox1, Label labeMinus)
        {
            double sum = 0;
            {
                if ((num1 != "0" && num2 != "0") || opt != 3)
                {
                    try
                    {
                        if (minus)
                        {
                            int buf;
                            buf = -1 * Convert.ToInt32(num1);
                            num1 = Convert.ToString(buf);
                        }
                        if (minus2)
                        {
                            int buf;
                            buf = -1 * Convert.ToInt32(num2);
                            num2 = Convert.ToString(buf);
                        }
                        switch (opt)
                        {
                            case 0:
                                sum = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                                break;
                            case 1:
                                sum = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                                break;
                            case 2:
                                sum = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                                break;
                            case 3:
                                sum = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                                break;


                            default:
                                MessageBox.Show("?");
                                break;
                        }
                        if (sum <= 999999999 && sum >= -999999999)
                        {
                            if (sum < 0)
                            {
                                labeMinus.Text = "-";
                            }
                            num3 = Convert.ToString(sum);
                            num3 = num3.Replace("-", "");

                            textBox1.Text = num3;
                        }
                        else
                        {
                            textBox1.Text = "EXCEEDED";
                        }
                        num1 = num3;
                        num2 = "";
                        num3 = "";
                        NextNum = 0;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error, check the data");
                    }
                }
                else
                {
                    textBox1.Text = "NOT / 0";
                    num1 = "";
                    num2 = "";
                    num3 = "";
                    NextNum = 0;
                }
            }
        }

        public void Reading(string number, TextBox textBox1)
        {
            if (NextNum == 0 && num1.Length < 9)
            {
                num1 += number;
                textBox1.Text = num1;
            }
            if (NextNum == 1 && num2.Length < 9)
            {
                num2 += number;
                textBox1.Text = num2;
            }
        }

        public void Clear(TextBox textBox1, Label labeMinus)
        {
            textBox1.Text = num3;
            num1 = "";
            num2 = "";
            num3 = "";
            textBox1.Text = "0";
            NextNum = 0;
            labeMinus.Text = "";
            minus = false;
            minus2 = false;
        }

        public void PlusMinus(Label labeMinus)
        {
            if (NextNum == 0)
            {
                if (labeMinus.Text == "")
                {
                    labeMinus.Text = "-";
                    minus = true;
                }
                else
                {
                    labeMinus.Text = "";
                    minus = false;
                }
            }
            if (NextNum == 1)
            {
                if (labeMinus.Text == "")
                {
                    labeMinus.Text = "-";
                    minus2 = true;
                }
                else
                {
                    labeMinus.Text = "";
                    minus2 = false;
                }
            }
        }

        public void Operation(TextBox textBox1, int option, Label labeMinus)
        {
            if (num1 != "")
            {
                if (num2 != "")
                {
                    Solution(textBox1, labeMinus);
                }
                NextNum = 1;//
                labeMinus.Text = "";
            }
            opt = option;

        }
    }
}
