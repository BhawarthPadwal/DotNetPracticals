﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Experiment1_5
{
    public partial class Default : System.Web.UI.Page
    {
        Calculator _Calculate;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Calculate = new Calculator();
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "6";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "9";
        }

        protected void ButtonComa_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + ",";
        }

        protected void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                calc_result.Value = "-" + calc_result.Value;
            }
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Addition";
                calc_result.Value = string.Empty;
            }
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Subtraction";
                calc_result.Value = string.Empty;
            }
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Multiplication";
                calc_result.Value = string.Empty;
            }
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Division";
                calc_result.Value = string.Empty;
            }
        }

        protected void ButtonPercentage_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Percentage";
                calc_result.Value = string.Empty;
            }
        }

        protected void ButtonCE_Click(object sender, EventArgs e)
        {
            if ((string)ViewState["Operation"] != null)
            {
                ViewState["Operation"] = null;
            }
            else if ((string)ViewState["Value1"] != null)
            {
                ViewState["Value1"] = null;
            }
        }

        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                string CharactersInTextBox = calc_result.Value;
                string FinalCharactersInTextBox = string.Empty;

                for (int i = 0; i < CharactersInTextBox.Length - 1; i++)
                {
                    FinalCharactersInTextBox = FinalCharactersInTextBox + CharactersInTextBox[i];
                }

                calc_result.Value = FinalCharactersInTextBox;
            }
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value2"] = calc_result.Value;
                calc_result.Value = string.Empty;

                try
                {
                    if ((string)ViewState["Operation"] == "Addition")
                    {
                        calc_result.Value = _Calculate.Add(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Subtraction")
                    {
                        calc_result.Value = _Calculate.Subtract(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Multiplication")
                    {
                        calc_result.Value = _Calculate.Multiply(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Division")
                    {
                        calc_result.Value = _Calculate.Divide(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Percentage")
                    {
                        calc_result.Value = _Calculate.Percentage(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else Response.Write("<script>alert('No Operation was recorded.')</script>");
                }
                catch (FormatException)
                {
                    Response.Write("<script>alert('Bad Input Format.')</script>");
                }
            }
        }

    }
}