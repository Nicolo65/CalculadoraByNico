using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraByNico
{
    class Metodos : Form1
    {

        public double currentOperator { get; set; }
        public double valor1 { get; set; }
        public double valor2 { get; set; }
        public double resultado { get; set; }
   

        public void suma(double op)
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



    }
}
