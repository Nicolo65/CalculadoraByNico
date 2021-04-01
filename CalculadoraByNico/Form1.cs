using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraByNico
{
    public partial class Form1 : Form
    {

        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            //Numero 0

            txtBox.Text = txtBox.Text + "0";


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Numero 1

            txtBox.Text = txtBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Numero 2

            txtBox.Text = txtBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Numero 3

            txtBox.Text = txtBox.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //Numero 4

            txtBox.Text = txtBox.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {

            //Numero 5

            txtBox.Text = txtBox.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {

            //Numero 6

            txtBox.Text = txtBox.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //Numero 7

            txtBox.Text = txtBox.Text + "7";


        }

        private void btn8_Click(object sender, EventArgs e)
        {

            //Numero 8

            txtBox.Text = txtBox.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {

            //Numero 9

            txtBox.Text = txtBox.Text + "9";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Limpiar

            txtBox.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Igual

            valor2 = Convert.ToDouble(txtBox.Text);

            switch (operacion)
            {
                case 1: resultado = valor1 + valor2; break;
                case 2: resultado = valor1 - valor2; break;
                case 3: resultado = valor1 * valor2; break;
                case 4: resultado = valor1 / valor2; break;
            }


            txtBox.Text = resultado.ToString();
            
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Suma

            operacion = 1;
            valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Resta

            operacion = 2;
            valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            //Multilplicacion

            operacion = 3;
            valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            //Division

            operacion = 4;
            valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            //Punto

            txtBox.Text = txtBox.Text + ".";

        }
    }
}
