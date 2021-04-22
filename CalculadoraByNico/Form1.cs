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
        /*
        public double valor1;
        public double valor2;
        public int operacion;

        public double resultado;
        */
        

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

            Metodos oIgual = new Metodos();
            oIgual.igual();
            
        }

        public void btnSuma_Click(object sender, EventArgs e)
        {
            //Suma

            Metodos oSuma = new Metodos();
            oSuma.suma(1);
            
            
        }

        public void btnResta_Click(object sender, EventArgs e)
        {
            //Resta

            Metodos oResta = new Metodos();
            oResta.resta(2);

        }

        public void btnMulti_Click(object sender, EventArgs e)
        {
            //Multilplicacion

            Metodos oMultiplicacion = new Metodos();
            oMultiplicacion.multi(3);

        }

        public void btnDiv_Click(object sender, EventArgs e)
        {
            //Division

            Metodos oDiv = new Metodos();
            oDiv.div(4);
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
