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
        Calc calculadora = new Calc();

        public Form1()
        {
            InitializeComponent();
        }


        public void btn0_Click(object sender, EventArgs e)
        {
            //Numero 0

            eventBtm("0");


        }

        public void btn1_Click(object sender, EventArgs e)
        {
            //Numero 1

            eventBtm("1");
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            //Numero 2

            eventBtm("2");
        }

        public void btn3_Click(object sender, EventArgs e)
        {
            //Numero 3

            eventBtm("3");

        }

        public void btn4_Click(object sender, EventArgs e)
        {
            //Numero 4

            eventBtm("4");

        }

        public void btn5_Click(object sender, EventArgs e)
        {

            //Numero 5

            eventBtm("5");

        }

        public void btn6_Click(object sender, EventArgs e)
        {

            //Numero 6

            eventBtm("6");

        }

        public void btn7_Click(object sender, EventArgs e)
        {
            //Numero 7

            eventBtm("7");


        }

        public void btn8_Click(object sender, EventArgs e)
        {

            //Numero 8

            eventBtm("8"); 

        }

        public void btn9_Click(object sender, EventArgs e)
        {

            //Numero 9

            eventBtm("9");

        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            //Limpiar

            txtBox.Text = "";

        }

        public void btnIgual_Click(object sender, EventArgs e)
        {
            //Igual

            calculadora.valor2 = Convert.ToDouble(txtBox.Text);
           txtBox.Text = calculadora.crrnOperation(calculadora.typeOperation, calculadora.valor1, calculadora.valor2);


        }

        public void btnSuma_Click(object sender, EventArgs e)
        {
            //Suma


            calculadora.valor1 = Convert.ToDouble(txtBox.Text);
            calculadora.typeOperation = 1;
            txtBox.Clear();
  
        }

        public void btnResta_Click(object sender, EventArgs e)
        {
            //Resta

            calculadora.valor1 = Convert.ToDouble(txtBox.Text);
            calculadora.typeOperation = 2;
            txtBox.Clear();

        }

        public void btnMulti_Click(object sender, EventArgs e)
        {
            //Multilplicacion

            calculadora.valor1 = Convert.ToDouble(txtBox.Text);
            calculadora.typeOperation = 3;
            txtBox.Clear();

        }

        public void btnDiv_Click(object sender, EventArgs e)
        {
            //Division

            calculadora.valor1 = Convert.ToDouble(txtBox.Text);
            calculadora.typeOperation = 4;
            txtBox.Clear();

        }

        public void btnPoint_Click(object sender, EventArgs e)
        {
            //Punto

            eventBtm(".");

        }
        
        public void eventBtm(string btm)
        {
            txtBox.Text = txtBox.Text + btm;
        }
        
        public void txtBox_TextChanged(object sender, EventArgs e)
        {
      


        }
    }
}
