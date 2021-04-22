using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraByNico
{
    class Metodos : Form1
    {

        private int currentOperator { get; set; }
        private double valor1 { get; set; }
        private double valor2 { get; set; }
        private double resultado { get; set; }


        // Modificadores

        public void setSuma1(double valor1)
        {
            this.currentOperator = 1;
            this.valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";

        }

        public void setSuma2(double valor2)
        {
            this.valor2 = Convert.ToDouble(txtBox.Text);
        }

     
        //Operacion 

        public void crrnOperation()
        {
            switch (currentOperator)
            {
                case 1: resultado = this.valor1 + this.valor2; break;
                case 2: resultado = this.valor1 - this.valor2; break;
                case 3: resultado = this.valor1 * this.valor2; break;
                case 4: resultado = this.valor1 / this.valor2; break;
            }

            this.resultado.ToString();

        }

        /*
        //Imprimir Resultado
        public string getResultado()
        {
            return resultado.ToString();
        }
        */
        

        /*
        public void suma(double op, double)
        {
            //suma                         

            this.currentOperator = op;
            this.valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";

        }

        public void resta(double op)
        {
            //Resta                                         
            currentOperator = op;
            valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";
        }

        public void multi(double op)
        {
            //Multiplicacion

            currentOperator = op;
            valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";
        }

        public void div(double op)
        {
            //Division
            currentOperator = op;
            valor1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";
        }

        public void igual()
        {
            valor2 = Convert.ToDouble(txtBox.Text);

            switch (this.currentOperator)
            {
                case 1: this.resultado = this.valor1 +this.valor2; break;
                case 2: this.resultado = this.valor1 - this.valor2; break;
                case 3: this.resultado = this.valor1 * this.valor2; break;
                case 4: this.resultado = this.valor1 / this.valor2; break;
            }


             txtBox.Text = this.resultado.ToString();

        }

        */

    }
}
