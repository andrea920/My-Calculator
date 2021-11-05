using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator_Perido
{
    public partial class Form1 : Form
    {
        float FNum, Ans;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + ".";
        }

        private void btnSIn_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "sin(";
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "tan(";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "cos(";
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "sinh(";
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "tanh(";
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "cosh(";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "π";
        }

        private void btn2pi_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "2π";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "log(";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "e";
        }

        private void btnAsinh_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "asinh(";
        }

        private void btnAcosh_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "acosh(";
        }

        private void btnParleft_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "(";
        }

        private void btnParRight_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + ")";
        }

        private void btn1overx_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "1/x";
        }

        private void btnHyp_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "hyp";
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "-";
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text == "0")
            {
                txtbxScreen.Text = "";
            }
            txtbxScreen.Text = txtbxScreen.Text + "x^2";
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text != "")
            {
                FNum = float.Parse(txtbxScreen.Text);
                txtbxScreen.Clear();
                txtbxScreen.Focus();
                count = 1;
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            FNum = float.Parse(txtbxScreen.Text);
            txtbxScreen.Clear();
            txtbxScreen.Focus();
            count = 3;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            FNum = float.Parse(txtbxScreen.Text);
            txtbxScreen.Clear();
            txtbxScreen.Focus();
            count = 4;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FNum = float.Parse(txtbxScreen.Text);
            txtbxScreen.Clear();
            txtbxScreen.Focus();
            count = 2;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtbxScreen.Clear();
            count = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtbxScreen.Clear();
            count = 0;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtbxScreen.Text != "")

            {
                txtbxScreen.Text = txtbxScreen.Text.Substring(0, txtbxScreen.Text.Length - 1);
            }
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    Ans = FNum - float.Parse(txtbxScreen.Text);
                    txtbxScreen.Text = Ans.ToString();
                    break;
                case 2:
                    Ans = FNum + float.Parse(txtbxScreen.Text);
                    txtbxScreen.Text = Ans.ToString();
                    break;
                case 3:
                    Ans = FNum * float.Parse(txtbxScreen.Text);
                    txtbxScreen.Text = Ans.ToString();
                    break;
                case 4:
                    Ans = FNum / float.Parse(txtbxScreen.Text);
                    txtbxScreen.Text = Ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
    }

