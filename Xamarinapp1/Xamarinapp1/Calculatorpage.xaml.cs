using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarinapp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculatorpage : ContentPage
    {
        public Calculatorpage()
        {
            InitializeComponent();
        }

        private void Btn0_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "0";
            }
        }


        private void Btn1_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "1";
            }
        }

        private void Btn2_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "2";
            }
        }

        private void Btn3_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "3";
            }
        }

        private void Btn4_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "4";
            }
        }

        private void Btn5_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "5";
            }
        }

        private void Btn6_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "6";
            }
        }

        private void Btn7_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "7";
            }
        }

        private void Btn8_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "8";
            }
        }

        private void Btn9_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length < 13)
            {
                if (lblsonuc.Text.Length == 1 && lblsonuc.Text == "0")
                    lblsonuc.Text = "";
                lblsonuc.Text = lblsonuc.Text + "9";
            }
        }

        private void Btnback_OnClicked(object sender, EventArgs e)
        {
            string yazi = lblsonuc.Text;
            int boyut = yazi.Length;

            if (boyut == 1)
            {
                yazi = yazi.Remove(boyut - 1);
                yazi = "0";
                lblsonuc.Text = yazi;
            }
            else
            {
                try
                {
                    yazi = yazi.Remove(boyut - 1);
                }
                catch (Exception exception)
                {
                }

                lblsonuc.Text = yazi;
            }
        }

        private void Btnclear_OnClicked(object sender, EventArgs e)
        {
            lblsonuc.Text = "0";
            lblsonuc1.Text = "";
            lblislem.Text = "";
            lblresult.Text = "";
        }

        private void Btnplus_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc1.Text.Length == 0 && lblsonuc.Text.Length == 0)
            {
            }
            else
            {
                if (lblsonuc1.Text.Length != 0)
                {
                    lblislem.Text = "+";
                    lblsonuc1.Text = (double.Parse(lblsonuc.Text) + double.Parse(lblsonuc1.Text)).ToString();
                    lblsonuc.Text = "0";
                }
                else
                {
                    lblsonuc1.Text = lblsonuc.Text;
                    lblislem.Text = "+";
                    lblsonuc.Text = "0";
                }
            }
        }

        private void Btnminnes_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc1.Text.Length == 0 && lblsonuc.Text.Length == 0)
            {
            }
            else
            {
                if (lblsonuc1.Text.Length != 0)
                {
                    lblislem.Text = "-";
                    lblsonuc1.Text = (-double.Parse(lblsonuc.Text) + double.Parse(lblsonuc1.Text)).ToString();
                    lblsonuc.Text = "0";
                }
                else
                {
                    lblsonuc1.Text = lblsonuc.Text;
                    lblislem.Text = "-";
                    lblsonuc.Text = "0";
                }
            }
        }

        private void BtnX_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text == "0" && lblsonuc1.Text == "0")
            {
                lblsonuc.Text = "";
                lblislem.Text = "";
                lblsonuc1.Text = "";
            }
            else
            {
                if (lblsonuc1.Text.Length == 0 && lblsonuc.Text.Length == 0)
                {
                }
                else
                {
                    if (lblsonuc1.Text.Length != 0)
                    {
                        lblislem.Text = "x";
                        lblsonuc1.Text = (double.Parse(lblsonuc.Text) * double.Parse(lblsonuc1.Text)).ToString();
                        lblsonuc.Text = "0";
                    }
                    else
                    {
                        lblsonuc1.Text = lblsonuc.Text;
                        lblislem.Text = "x";
                        lblsonuc.Text = "0";
                    }
                }
            }
        }

        private void Btndivide_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text == "0")
            {
                lblresult.Text = "Tanımsız";
            }
            else
            {
                lblresult.Text = "";
                if (lblsonuc1.Text.Length == 0 && lblsonuc.Text.Length == 0)
                {
                }
                else
                {
                    if (lblsonuc1.Text.Length != 0)
                    {
                        lblislem.Text = "/";
                        lblsonuc1.Text = (double.Parse(lblsonuc.Text) / double.Parse(lblsonuc1.Text)).ToString();
                        lblsonuc.Text = "0";
                    }
                    else
                    {
                        lblsonuc1.Text = lblsonuc.Text;
                        lblislem.Text = "/";
                        lblsonuc.Text = "0";
                    }
                }
            }
        }

        private void Btnresult_OnClicked(object sender, EventArgs e)
        {
            if (lblislem.Text == "+")
            {
                try
                {
                    lblresult.Text = (double.Parse(lblsonuc.Text) + double.Parse(lblsonuc1.Text)).ToString();
                    lblsonuc.Text = "0";
                    lblislem.Text = "";
                    lblsonuc1.Text = "";
                }
                catch (Exception exception)
                {
                   
                }
               
            }
            else if (lblislem.Text == "-")
            {
                try
                {
                    lblresult.Text = (-double.Parse(lblsonuc.Text) + double.Parse(lblsonuc1.Text)).ToString();
                    lblsonuc.Text = "0";
                    lblislem.Text = "";
                    lblsonuc1.Text = "";
                }
                catch (Exception exception)
                {
                    
                }
               
            }
            else if (lblislem.Text == "x")
            {
                try
                {
                    lblresult.Text = (double.Parse(lblsonuc.Text) * double.Parse(lblsonuc1.Text)).ToString();
                    lblsonuc.Text = "0";
                    lblislem.Text = "";
                    lblsonuc1.Text = "";
                }
                catch (Exception exception)
                {
                    
                }
            }
            else if (lblislem.Text == "/")
            {
                try
                {
                    if (lblsonuc.Text != "0")
                    {
                        lblresult.Text = (double.Parse(lblsonuc.Text) / double.Parse(lblsonuc1.Text)).ToString();
                        lblsonuc.Text = "0";
                        lblislem.Text = "";
                        lblsonuc1.Text = "";
                    }
                    else
                    {
                        lblresult.Text = "Tanımsız";
                    }
                }
                catch (Exception exception)
                {
                    
                }
            }
            else if (lblsonuc.Text.Length != 0)
            {
                if (lblsonuc.Text[0] == '%')
                {
                    try
                    {
                        string sayi = lblsonuc.Text.Remove(0, 1);
                        lblresult.Text = (((double.Parse(sayi) / 100) * double.Parse(lblislem.Text))).ToString();
                        lblsonuc.Text = "0";
                        lblislem.Text = "";
                    }
                    catch (Exception exception)
                    {
                        lblsonuc.Text = "0";
                    }
                }
            }
            else
            {
            }
        }

        private void Btndot_OnClicked(object sender, EventArgs e)
        {
            if (lblsonuc.Text.Length == 0)
            {
                lblsonuc.Text = "0,";
            }
            else
            {
                char dot = '\0';
                foreach (var VARIABLE in lblsonuc.Text)
                {
                    if (VARIABLE == '.')
                    {
                        dot = VARIABLE;
                        break;
                    }
                }

                if (dot == '.')
                {
                }
                else
                {
                    lblsonuc.Text = lblsonuc.Text + ",";
                }
            }
        }

        private void Btnpercent_OnClicked(object sender, EventArgs e)
        {
            lblresult.Text = "";
            if (lblislem.Text == "+" || lblislem.Text == "-" || lblislem.Text == "x" || lblislem.Text == "/")
            {
                lblsonuc.Text = "0";
            }
            else
            {
                try
                {
                    if (lblsonuc.Text[0] == '%')
                    {
                        lblsonuc.Text = "0";
                        lblsonuc1.Text = "";
                        lblislem.Text = "";
                    }
                    else
                    {
                        lblislem.Text = lblsonuc.Text;
                        //  lblsonuc1.Text = ((double.Parse(lblsonuc.Text) * double.Parse(lblislem.Text) / 100)).ToString();
                        lblsonuc.Text = "%";
                    }
                }
                catch (Exception exception)
                {
                    
                }
                
            }
        }
    }
}