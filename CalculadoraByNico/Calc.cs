using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraByNico
{
    class Calc
    {

        public double valor1 { get; set; }
        public double valor2 { get; set; }
        private double resultado { get; set; }
        public int typeOperation { get; set; }


        public string crrnOperation(int pCurrentOperator, double pValor1, double pValor2)
        {
            switch (pCurrentOperator)
            {
                case 1: resultado = pValor1 + pValor2; break;
                case 2: resultado = pValor1 - pValor2; break;
                case 3: resultado = pValor1 * pValor2; break;
                case 4: resultado = pValor1 / pValor2; break;
            }

           return this.resultado.ToString();

        }


    }
}
