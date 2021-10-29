using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + ".";
        }

        private void btnAdic_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            operacao = "SOMA";
            lab.Text = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            operacao = "SUBTRAÇÃO";
            lab.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            operacao = "MULTIPLICAÇÃO";
            lab.Text = "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            operacao = "DIVISÃO";
            lab.Text = "÷";
        }

        private void btnApag_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lab.Text = ""; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private string RemoveLastChar(string text)
        {
            throw new NotImplementedException();
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtresultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRAÇÃO")
            {
                txtresultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICAÇÃO")
            {
                txtresultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISÃO")
            {
                txtresultado.Text = Convert.ToString(valor1 / valor2);
            }
        }
    }
} 
